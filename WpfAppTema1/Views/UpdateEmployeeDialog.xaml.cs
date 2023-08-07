using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for UpdateEmployeeDialog.xaml
    /// </summary>
    public partial class UpdateEmployeeDialog : Window
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public UpdateEmployeeDialog()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            // Obțineți valorile introduse de utilizator din controalele TextBox
            Name = txtEmployeeName.Text;
            Position = txtPosition.Text;
            Username = txtUsername.Text;
            Password = txtPassword.Text;
            // Închideți fereastra de dialog
            DialogResult = true;
        }
    }
}
