using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace WilenInmobiliaria
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlconnection;
        Menu ventana = new Menu();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            Login();
            Cargo();
        }
        private void Login()
        {
            try
            {
                sqlconnection.Open();
                string query = "SELECT Nombre, Contraseña FROM Usuario WHERE Nombre=@nombre AND Contraseña=@contra";

                SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);
                sqlCommand.Parameters.AddWithValue("@nombre", txtUsuario.Text);
                sqlCommand.Parameters.AddWithValue("@contra", txtPass.Password);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    MessageBox.Show("Exito Completo");

                    /*ventana.lbNombreUser.Content = this.txtUsuario.Text;
                    ventana.lbCargoUser.Content = this.txtCargo.Text;
                    ventana.Show();
                    if (txtCargo.Text == "Empleado")
                    {
                        ventana.btnUsuarios.IsEnabled = false;
                        ventana.btnUsuarios.Visibility = Visibility.Collapsed;
                    }*/


                    this.Close();
                }

                else
                {
                    MessageBox.Show("Datos Incorrectos");
                    txtPass.Password = string.Empty;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlconnection.Close();

            }

        }
        private void Cargo()
        {
            try
            {
                sqlconnection.Open();
                string query = "SELECT c.Cargos,c.Id_Acceso FROM Acceso c INNER JOIN Empleado b ON c.Id_Acceso=b.Id_Acceso INNER JOIN Usuario a ON b.Id_Empleado=a.Id_Usuario WHERE a.Nombre=@nombre";
                SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);
                sqlCommand.Parameters.AddWithValue("@nombre", txtUsuario.Text);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    /*ventana.lbCargoUser.Content = sqlDataReader["Cargos"].ToString();
                    txtCargo.Text = sqlDataReader["Cargos"].ToString();*/

                    //string i;
                    //i= sqlDataReader["Id_Acceso"].ToString();
                    //WindowContenedorPrincipal Ventana = new WindowContenedorPrincipal();

                    //if (i == "2")
                    //{
                    //    i = "2";
                    //}
                    //else
                    //{
                    //    i = "1";
                    //}


                    //ventana.Cargo = int.Parse(i);
                    //if (ventana.lbCargoUser.ToString() == "Empleado")
                    //{
                    //    ventana.btnUsuarios.IsEnabled = false;
                    //    ventana.btnUsuarios.Visibility = Visibility.Collapsed;
                    //}

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlconnection.Close();

            }
        }

        private void BtnLogin_MouseLeave(object sender, MouseEventArgs e)
        {
            btnLogin.Background = new SolidColorBrush(Color.FromRgb(27, 100, 207));
        }

        private void BtnLogin_MouseEnter(object sender, MouseEventArgs e)
        {
            btnLogin.Background = Brushes.Blue;
        }
    }
}

