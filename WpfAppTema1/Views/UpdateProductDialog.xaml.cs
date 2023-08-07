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
using WpfAppTema1.ViewModels;

namespace WpfAppTema1.Views
{
    /// <summary>
    /// Interaction logic for UpdateProductDialog.xaml
    /// </summary>
    
    public partial class UpdateProductDialog : Window
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }

        public bool Availability;
        public UpdateProductDialog()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            // Obțineți valorile introduse de utilizator din controalele TextBox
            Name = txtProductName.Text;
            double.TryParse(txtPrice.Text, out double price);
            Price = price;
            Availability = IsAvailable;
            // Închideți fereastra de dialog
            DialogResult = true;
        }
       
        
    }
}
