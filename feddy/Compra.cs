
using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace feddy
{
    public partial class Compra : Form
    {
        private string metodoPago;

        public Compra()
        {
            InitializeComponent();

            MessageBox.Show("Se creó el formulario Compra.");

            this.Load += Compra_Load;

            metodoPago = "No especificado";
        }

        public Compra(string metodoPago) : this()
        {
            this.metodoPago = metodoPago;
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer reproductor = new SoundPlayer(
                    @"C:\Users\sanch\source\repos\feddy\feddy\Resources\gato riendo.wav"
                );
                reproductor.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo reproducir el sonido: " + ex.Message);
            }
            MessageBox.Show("El formulario Compra_Load sí se ejecutó.");

            if (GuardarCompra())
            {
                MessageBox.Show("La compra se guardó. Ahora se mostrará el ticket.");
                MostrarTicket();
            }
        }

        private bool GuardarCompra()
        {
            Carriton carrito = SesionPedido.GetCarrito();
            List<Producto> productos = carrito.GetProductos();

            if (productos.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.");
                Close();
                return false;
            }

            Conexion nuevaConexion = new Conexion();

            using (MySqlConnection conexion = nuevaConexion.ObtenerConexion())
            {
                conexion.Open();

                using (MySqlTransaction transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        string consultaMetodo =
                            "SELECT id_metodo FROM metodos_pago " +
                            "WHERE nombre_metodo = @metodo";

                        int idMetodo;

                        using (MySqlCommand comando = new MySqlCommand(
                            consultaMetodo, conexion, transaccion))
                        {
                            comando.Parameters.AddWithValue("@metodo", metodoPago);
                            idMetodo = Convert.ToInt32(comando.ExecuteScalar());
                        }

                        decimal total = carrito.CalcularSubtotal();

                        string consultaPedido =
                            "INSERT INTO pedidos (id_metodo, total) " +
                            "VALUES (@metodo, @total)";

                        long idPedido;

                        using (MySqlCommand comando = new MySqlCommand(
                            consultaPedido, conexion, transaccion))
                        {
                            comando.Parameters.AddWithValue("@metodo", idMetodo);
                            comando.Parameters.AddWithValue("@total", total);
                            comando.ExecuteNonQuery();

                            idPedido = comando.LastInsertedId;
                        }

                        foreach (Producto producto in productos)
                        {
                            Pizza pizza = producto as Pizza;

                            if (pizza == null)
                                continue;

                            string consultaDetalle =
                                "INSERT INTO detalle_pedido " +
                                "(id_pedido, tamano, precio_base, porciones_queso, " +
                                "salsa, orilla_rellena, precio_total) " +
                                "VALUES (@pedido, @tamano, @base, @queso, " +
                                "@salsa, @orilla, @total)";

                            long idDetalle;

                            using (MySqlCommand comando = new MySqlCommand(
                                consultaDetalle, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@pedido", idPedido);
                                comando.Parameters.AddWithValue(
                                    "@tamano", pizza.GetTamano().GetNombre());
                                comando.Parameters.AddWithValue(
                                    "@base", pizza.GetPrecioBase());
                                comando.Parameters.AddWithValue(
                                    "@queso", pizza.GetPorcionesQueso());
                                comando.Parameters.AddWithValue(
                                    "@salsa", pizza.GetSalsa());
                                comando.Parameters.AddWithValue(
                                    "@orilla", pizza.GetOrillaQueso());
                                comando.Parameters.AddWithValue(
                                    "@total", pizza.CalcularPrecio());

                                comando.ExecuteNonQuery();
                                idDetalle = comando.LastInsertedId;
                            }

                            foreach (Ingrediente ingrediente in pizza.GetIngredientes())
                            {
                                string consultaIngrediente =
                                    "SELECT id_ingrediente FROM ingredientes " +
                                    "WHERE nombre = @nombre";

                                int idIngrediente;

                                using (MySqlCommand comando = new MySqlCommand(
                                    consultaIngrediente, conexion, transaccion))
                                {
                                    comando.Parameters.AddWithValue(
                                        "@nombre", ingrediente.GetNombre());

                                    object resultado = comando.ExecuteScalar();

                                    if (resultado == null)
                                        throw new Exception(
                                            "No se encontró el ingrediente: " +
                                            ingrediente.GetNombre());

                                    idIngrediente = Convert.ToInt32(resultado);
                                }

                                string consultaRelacion =
                                    "INSERT INTO detalle_ingredientes " +
                                    "(id_detalle, id_ingrediente, precio_unitario) " +
                                    "VALUES (@detalle, @ingrediente, @precio)";

                                using (MySqlCommand comando = new MySqlCommand(
                                    consultaRelacion, conexion, transaccion))
                                {
                                    comando.Parameters.AddWithValue(
                                        "@detalle", idDetalle);
                                    comando.Parameters.AddWithValue(
                                        "@ingrediente", idIngrediente);
                                    comando.Parameters.AddWithValue(
                                        "@precio", ingrediente.GetPrecio());

                                    comando.ExecuteNonQuery();
                                }
                            }
                        }

                        transaccion.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaccion.Rollback();
                        MessageBox.Show(
                            "No se pudo guardar la compra: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        

        private void MostrarTicket()
        {
            Carriton carrito = SesionPedido.GetCarrito();
            List<Producto> productos = carrito.GetProductos();

            lstProductos.Items.Clear();

            foreach (Producto producto in productos)
            {
                lstProductos.Items.Add(
                    producto.GetNombre() + " - $" +
                    producto.CalcularPrecio().ToString("0.00")
                );
            }

            lblTitulo.Text = "PIZZERÍA";
            lblMensaje.Text = "¡Compra realizada!";
            lblTotal.Text = "Total: $" +
                carrito.CalcularSubtotal().ToString("0.00");
            lblMetodoPago.Text = "Método de pago: " + metodoPago;

            carrito.VaciarCarrito();
        }

    }
}
