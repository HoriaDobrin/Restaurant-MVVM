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

namespace WpfAppTema1.Views
{
    /// <summary>
    /// Interaction logic for AddProductDialog.xaml
    /// </summary>
    public partial class AddProductDialog : Window
    {
        public string ProductName { get; private set; }
        public double Price { get; private set; }

        public AddProductDialog()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Obțineți valorile introduse de utilizator din controalele TextBox
            ProductName = txtProductName.Text;
            double.TryParse(txtPrice.Text, out double price);
            Price = price;

            // Închideți fereastra de dialog
            DialogResult = true;
        }
    }
}
