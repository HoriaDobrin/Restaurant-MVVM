using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfAppTema1.Models;
using WpfAppTema1.ViewModels.WpfAppTema1.ViewModels;
using WpfAppTema1.Views;

namespace WpfAppTema1.ViewModels
{
    internal class ProductViewModel : BaseViewModel
    {
        private RestaurantContext _context;

        public ObservableCollection<Product> Products { get; set; }
        
        private UpdateProductDialog _updateProductDialog;

        public ICommand AddProductCommand { get; }
        public ICommand UpdateProductCommand { get; private set; }
        public ICommand DeleteProductCommand { get; }

        private Product _selectedProduct;

        public Product SelectedProduct
        {
            get { return _selectedProduct; }
            set
            {
                _selectedProduct = value;
                OnPropertyChanged(nameof(SelectedProduct));
            }
        }

        public ProductViewModel()
        {
            _context = new RestaurantContext();
            _updateProductDialog = new UpdateProductDialog();

            LoadProducts();

            AddProductCommand = new RelayCommand(AddProductCommandExecute);
            DeleteProductCommand = new RelayCommand(DeleteProductCommandExecute);
            UpdateProductCommand = new RelayCommand(UpdateProductCommandExecute);
        }

        private void LoadProducts()
        {
            Products = new ObservableCollection<Product>(_context.Products);
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            Products.Add(product);
        }

        private void AddProductCommandExecute(object parameter)
        {
            var dialog = new AddProductDialog();
            if (dialog.ShowDialog() == true)
            {
                // Utilizați valorile introduse de utilizator pentru a crea un obiect Product nou
                var newProduct = new Product
                {
                    name = dialog.ProductName,
                    price = dialog.Price,
                    isavailable = true // Setați starea disponibilității produsului aici sau adăugați un control în fereastra de dialog
                };

                // Adăugați produsul nou în colecția Products
                AddProduct(newProduct);
            }
        }

        private void DeleteProductCommandExecute()
        {
            if (SelectedProduct != null && Products.Contains(SelectedProduct))
            {
                // Căutați obiectul corespunzător în contextul _context.Products
                var productToDelete = _context.Products.FirstOrDefault(p => p.id == SelectedProduct.id);

                if (productToDelete != null)
                {
                    // Eliminați obiectul găsit din context
                    _context.Products.Remove(productToDelete);
                    _context.SaveChanges();
                }

                // Eliminați obiectul din colecția Products
                Products.Remove(SelectedProduct);
            }
        }

        private void UpdateProductCommandExecute()
        {
            // Deschideți un dialog de editare și obțineți datele actualizate
            // Puteți utiliza, de exemplu, un dialog modal sau o fereastră nouă pentru editare
            if (SelectedProduct != null)
            {
                _updateProductDialog.ShowDialog();

                // Actualizați produsul cu noile valori
                if (_updateProductDialog.Name != "") { SelectedProduct.name = _updateProductDialog.Name; }
                if (_updateProductDialog.Price != null) { SelectedProduct.price = _updateProductDialog.Price; }
                SelectedProduct.isavailable = _updateProductDialog.Availability;

                // Salvare în baza de date sau în altă parte necesară
                _context.SaveChanges();

                // Găsiți indexul produsului în colecția Products
                int index = Products.IndexOf(SelectedProduct);

                // Verificați dacă produsul a fost găsit în colecție
                if (index != -1)
                {
                    // Actualizați produsul cu noile valori
                    Products[index] = SelectedProduct;
                }
                OnPropertyChanged(nameof(SelectedProduct));
                
            }
        }


       
    }
}
