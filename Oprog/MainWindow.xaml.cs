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

namespace Oprog
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Oprog.bddesenvDataSet bddesenvDataSet = ((Oprog.bddesenvDataSet)(this.FindResource("bddesenvDataSet")));
            // Cargar datos en la tabla usuaris. Puede modificar este código según sea necesario.
            Oprog.bddesenvDataSetTableAdapters.usuarisTableAdapter bddesenvDataSetusuarisTableAdapter = new Oprog.bddesenvDataSetTableAdapters.usuarisTableAdapter();
            bddesenvDataSetusuarisTableAdapter.Fill(bddesenvDataSet.usuaris);
            System.Windows.Data.CollectionViewSource usuarisViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("usuarisViewSource")));
            usuarisViewSource.View.MoveCurrentToFirst();
        }
    }
}
