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

namespace WpfAppTema1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (var context = new RestaurantContext())
            {
                if (context.Database.CanConnect())
                {
                    StatusTextBlock.Text = "Conexiunea cu baza de date a fost realizată cu succes!";
                }
                else
                {
                    StatusTextBlock.Text = "Nu s-a putut realiza conexiunea cu baza de date.";
                }
            }
        }
    }
}
