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
using System.Windows.Shapes;

namespace WilenInmobiliaria
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public bool clientePush;
        public bool vendedoresPush;
        public bool ventasPush;
        public Menu()
        {
            InitializeComponent();
            Inicializar_Push();
        }
        public void Inicializar_Push()
        {
            clientePush = false;
            vendedoresPush = false;
            ventasPush = false;
        }

        private void BtnClientes_Click(object sender, RoutedEventArgs e)
        {
            Clientes clientes = new Clientes();
            this.Hide();
            clientes.ShowDialog();
        }

        private void BtnClientes_MouseEnter(object sender, MouseEventArgs e)
        {
            Clientes clientes = new Clientes();
            this.Hide();
            clientes.ShowDialog();
        }

        private void BtnClientes_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void BtnApagar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void BtnVendedores_Click(object sender, RoutedEventArgs e)
        {
            Vendedores vendedores = new Vendedores();
            this.Hide();
            vendedores.ShowDialog();
        }

        private void BtnInmueble_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnVentas_Click(object sender, RoutedEventArgs e)
        {
            Ventas ventas = new Ventas();
            this.Hide();
            ventas.ShowDialog();
        }

        private void BtnReportes_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
