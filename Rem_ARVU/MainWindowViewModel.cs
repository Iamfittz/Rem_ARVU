using Rem_ARVU.Rem_ARVUDataset;
using Rem_ARVU.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Rem_ARVU {
    public class MainWindowViewModel : ViewModelBase {
        private readonly DataModule _dataModule;
        private readonly DataService _dataService;
        private readonly ProductFilter _productFilter;
        private readonly DialogService _dialogService;
        public MainWindowViewModel() {
            _dataModule = new DataModule();
            _dataService = new DataService(_dataModule);
            _productFilter = new ProductFilter();
            _dialogService = new DialogService(_dataModule);

            Login();
            LoadAllData();
        }
        #region Properties
        private List<ProductGroups> _productGroups;
        private List<Vendors> _vendors;
        private List<Products> _products;
        private List<Products> _filteredProducts;
        private ProductGroups _selectedProductGroup;
        private Vendors _selectedVendor;
        private Products _selectedProduct;

        public List<ProductGroups> ProductGroups {
            get => _productGroups;
            set { _productGroups = value; OnPropertyChanged(); }
        }
        public List<Vendors> Vendors {
            get => _vendors;
            set { _vendors = value; OnPropertyChanged(); }
        }
        public List<Products> Products {
            get => _products;
            set {
                _products = value;
                UpdateFilteredProducts();
                OnPropertyChanged();
            }
        }
        public List<Products> FilteredProducts {
            get => _filteredProducts;
            set { _filteredProducts = value; OnPropertyChanged(); }
        }
        public ProductGroups SelectedProductGroup {
            get => _selectedProductGroup;
            set {
                _selectedProductGroup = value;
                if (value != null) SelectedVendor = null;
                UpdateFilteredProducts();
                OnPropertyChanged();
            }
        }
        public Vendors SelectedVendor {
            get => _selectedVendor;
            set {
                _selectedVendor = value;
                if (value != null) SelectedProductGroup = null;
                UpdateFilteredProducts();
                OnPropertyChanged();
            }
        }
        public Products SelectedProduct {
            get => _selectedProduct;
            set { _selectedProduct = value; OnPropertyChanged(); }
        }
        #endregion

        #region Core Methods
        private void Login() {
            while (!_dataModule.RequireLogOn()) {
                // Keep trying until login succeeds
            }
        }

        private void LoadAllData() {
            ProductGroups = _dataService.GetProductGroups();
            Vendors = _dataService.GetVendors();
            Products = _dataService.GetProducts();
        }

        private void UpdateFilteredProducts() {
            FilteredProducts = _productFilter.GetFilteredProducts(_products, _selectedProductGroup, _selectedVendor);
        }
        #endregion

        #region Command Methods
        private void CreateProductGroup() {
            if (_dialogService.ShowCreateProductGroupDialog())
                ProductGroups = _dataService.GetProductGroups();
        }

        private void UpdateProductGroup() {
            if (_dialogService.ShowUpdateProductGroupDialog(SelectedProductGroup)) {
                ProductGroups = _dataService.GetProductGroups();
                Products = _dataService.GetProducts();
            }
        }

        private void DeleteProductGroup() {
            if (_dialogService.ShowDeleteConfirmation(SelectedProductGroup.Name)) {
                _dataService.DeleteProductGroup(SelectedProductGroup);
                ProductGroups = _dataService.GetProductGroups();
                Products = _dataService.GetProducts();
            }
        }

        // Vendor Commands
        private void CreateVendor() {
            if (_dialogService.ShowCreateVendorDialog())
                Vendors = _dataService.GetVendors();
        }

        private void UpdateVendor() {
            if (_dialogService.ShowUpdateVendorDialog(SelectedVendor)) {
                Vendors = _dataService.GetVendors();
                Products = _dataService.GetProducts();
            }
        }

        private void DeleteVendor() {
            if (_dialogService.ShowDeleteConfirmation(SelectedVendor.Name)) {
                _dataService.DeleteVendor(SelectedVendor);
                Vendors = _dataService.GetVendors();
                Products = _dataService.GetProducts();
            }
        }

        // Product Commands
        private void CreateProduct() {
            if (_dialogService.ShowCreateProductDialog())
                Products = _dataService.GetProducts();
        }

        private void UpdateProduct() {
            if (_dialogService.ShowUpdateProductDialog(SelectedProduct))
                Products = _dataService.GetProducts();
        }

        private void DeleteProduct() {
            if (_dialogService.ShowDeleteConfirmation(SelectedProduct.Name)) {
                _dataService.DeleteProduct(SelectedProduct);
                Products = _dataService.GetProducts();
            }
        }

        private void Logout() {
            _dataModule.LogOff();
            ProductGroups = new List<ProductGroups>();
            Vendors = new List<Vendors>();
            Products = new List<Products>();
            SelectedProduct = null;
            SelectedProductGroup = null;
            SelectedVendor = null;
        }
        #endregion

        #region Commands
        public ICommand CreateProductGroupCommand => new RelayCommand(CreateProductGroup, () => _dataModule.IsLoggedOn);
        public ICommand UpdateProductGroupCommand => new RelayCommand(UpdateProductGroup, () => SelectedProductGroup != null && _dataModule.IsLoggedOn);
        public ICommand DeleteProductGroupCommand => new RelayCommand(DeleteProductGroup, () => SelectedProductGroup != null && _dataModule.IsLoggedOn);

        public ICommand CreateVendorCommand => new RelayCommand(CreateVendor, () => _dataModule.IsLoggedOn);
        public ICommand UpdateVendorCommand => new RelayCommand(UpdateVendor, () => SelectedVendor != null && _dataModule.IsLoggedOn);
        public ICommand DeleteVendorCommand => new RelayCommand(DeleteVendor, () => SelectedVendor != null && _dataModule.IsLoggedOn);

        public ICommand CreateProductCommand => new RelayCommand(CreateProduct, () => _dataModule.IsLoggedOn);
        public ICommand UpdateProductCommand => new RelayCommand(UpdateProduct, () => SelectedProduct != null && _dataModule.IsLoggedOn);
        public ICommand DeleteProductCommand => new RelayCommand(DeleteProduct, () => SelectedProduct != null && _dataModule.IsLoggedOn);

        public ICommand RefreshProductGroupsCommand => new RelayCommand(LoadAllData, () => _dataModule.IsLoggedOn);
        public ICommand RefreshVendorsCommand => new RelayCommand(LoadAllData, () => _dataModule.IsLoggedOn);
        public ICommand RefreshProductsCommand => new RelayCommand(LoadAllData, () => _dataModule.IsLoggedOn);
        public ICommand LogoutCommand => new RelayCommand(Logout, () => _dataModule.IsLoggedOn);
        public ICommand LogInCommand => new RelayCommand(Login, () => !_dataModule.IsLoggedOn);
        #endregion
    }
}
