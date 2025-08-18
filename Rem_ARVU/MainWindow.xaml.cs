using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Linq;
using RemObjects.DataAbstract.Linq;
using Rem_ARVU.Rem_ARVUDataset;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Rem_ARVU.EditForms;

namespace Rem_ARVU
{
    public partial class MainWindow : Window, INotifyPropertyChanged {
        #region Private fields
        private DataModule fDataModule;
        #endregion

        public MainWindow() {
            InitializeComponent();
            DataContext = this;
            fDataModule = new DataModule();
            ExecuteLogIn();
            RefreshProductGroups();
            RefreshProducts();
        }

        private void ExecuteLogIn() {
            bool isLogOn = fDataModule.RequireLogOn();
            while (!isLogOn) {
                isLogOn = fDataModule.RequireLogOn();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private List<ProductGroups> _productGroups;
        private List<Products> _products;
        private ProductGroups _selectedProductGroup;
        private Products _selectedProduct;
        private int _selectedTabIndex;

        public List<ProductGroups> ProductGroups {
            get => _productGroups;
            set {
                _productGroups = value;
                OnPropertyChanged();
            }
        }
        public ProductGroups SelectedProductGroup {
            get => _selectedProductGroup;
            set {
                _selectedProductGroup = value;
                OnPropertyChanged();
            }
        }
        private void RefreshProductGroups() => ProductGroups = fDataModule.GetItems<ProductGroups>();
        public ICommand RefreshProductGroupsCommand => new RelayCommand(RefreshProductGroups);

        public List<Products> Products {
            get => _products;
            set {
                _products = value;
                OnPropertyChanged();
            }
        }
        public Products SelectedProduct {
            get => _selectedProduct;
            set {
                _selectedProduct = value;
                OnPropertyChanged();
            }
        }
        private void RefreshProducts() => Products = fDataModule.GetItems<Products>();
        public ICommand RefreshProductsCommand => new RelayCommand(RefreshProducts);
        private void ExecuteDeleteProduct() {
            if (SelectedProduct != null) {
                fDataModule.DeleteRow(SelectedProduct);
                RefreshProducts();
            }
        }

        public ICommand UpdateProductCommand => new RelayCommand(ExecuteUpdateProduct, CanExecuteModify);
        public ICommand DeleteProductCommand => new RelayCommand(ExecuteDeleteProduct, CanExecuteModify);

        private bool CanExecuteModify() {
            return SelectedTabIndex == 0 ? SelectedProductGroup != null : SelectedProduct != null;
        }
        public int SelectedTabIndex {
            get => _selectedTabIndex;
            set {
                _selectedTabIndex = value;
                OnPropertyChanged();
            }
        }





        private void ExecuteCreateProduct() {
            var form = new ProductForm(fDataModule, new Products(), isNew: true);
            if (form.ShowDialog() == true) {
                RefreshProducts();
            }
        }

        private void ExecuteUpdateProduct() {
            if (SelectedProductGroup != null) {
                var form = new ProductForm(fDataModule, (Products)SelectedProduct.Clone(), isNew: false);
                if (form.ShowDialog() == true) {
                    RefreshProducts();
                }
            }
        }

        private void ExecuteCreateProductGroup() {
            var form = new ProductGroupForm(fDataModule, new ProductGroups(), isNew: true);
            if (form.ShowDialog() == true) {
                RefreshProductGroups();
            }
        }

        private void ExecuteUpdateProductGroup() {
            if (SelectedProductGroup != null) {
                var form = new ProductGroupForm(fDataModule, (ProductGroups)SelectedProductGroup.Clone(), isNew: false);
                if (form.ShowDialog() == true) {
                    RefreshProductGroups();
                }
            }
        }

        private void ExecuteDeleteProductGroup() {
            if (SelectedProductGroup != null) {
                fDataModule.DeleteRow<ProductGroups>(SelectedProductGroup);
                RefreshProductGroups();
            }
        }

        public ICommand SelectProductGroupsCommand => new RelayCommand(() => SelectedTabIndex = 0);
        public ICommand SelectProductsCommand => new RelayCommand(() => SelectedTabIndex = 1);
        public ICommand CreateProductGroupCommand => new RelayCommand(ExecuteCreateProductGroup);
        public ICommand UpdateProductGroupCommand => new RelayCommand(ExecuteUpdateProductGroup, CanExecuteModify);
        public ICommand DeleteProductGroupCommand => new RelayCommand(ExecuteDeleteProductGroup, CanExecuteModify);
        public ICommand CreateProductCommand => new RelayCommand(ExecuteCreateProduct);
        public ICommand LogoutCommand => new RelayCommand(ExecuteLogout, () => fDataModule.IsLoggedOn);
        public ICommand LogInCommand => new RelayCommand(ExecuteLogIn, () => !fDataModule.IsLoggedOn);
        private void ExecuteLogout() {
            fDataModule.LogOff();
            _productGroups = new List<ProductGroups>();
            _products = new List<Products>();
            _selectedProduct = null;
            _selectedProductGroup = null;
        }
    }

    public class RelayCommand : ICommand {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        public RelayCommand(Action execute, Func<bool> canExecute = null) {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter) => _canExecute?.Invoke() ?? true;
        public void Execute(object parameter) => _execute();
        public event EventHandler CanExecuteChanged {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}
