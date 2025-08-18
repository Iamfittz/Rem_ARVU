using Rem_ARVU.Rem_ARVUDataset;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Rem_ARVU.EditForms {
    /// <summary>
    /// Interaction logic for ProductForm.xaml
    /// </summary>
    public partial class ProductForm : Window, INotifyPropertyChanged {
        private readonly DataModule _dataModule;
        private readonly Products _product;
        private readonly bool _isNew;
        private List<ProductGroups> _productGroups;

        public ProductForm(DataModule dataModule, Products product, bool isNew) {
            InitializeComponent();
            DataContext = this;
            _dataModule = dataModule;
            _product = product;
            _isNew = isNew;

            ProductGroups = _dataModule.GetItems<ProductGroups>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Products Product => _product;

        public string Code {
            get => _product.Code;
            set {
                _product.Code = value;
                OnPropertyChanged();
            }
        }

        public string PName {
            get => _product.Name;
            set {
                _product.Name = value;
                OnPropertyChanged();
            }
        }

        public string Details {
            get => _product.Details;
            set {
                _product.Details = value;
                OnPropertyChanged();
            }
        }

        public string URL {
            get => _product.URL;
            set {
                _product.URL = value;
                OnPropertyChanged();
            }
        }

        public short? Warranty {
            get => _product.Warranty;
            set {
                _product.Warranty = value.Value;
                OnPropertyChanged();
            }
        }

        public bool Obsolete {
            get => _product.Obsolete;
            set {
                _product.Obsolete = value;
                OnPropertyChanged();
            }
        }

        public string Notes {
            get => _product.Notes;
            set {
                _product.Notes = value;
                OnPropertyChanged();
            }
        }

        public int? Vendor {
            get => _product.Vendor;
            set {
                _product.Vendor = value.Value;
                OnPropertyChanged();
            }
        }

        public long Group {
            get => _product.Group;
            set {
                _product.Group = (int)value;
                OnPropertyChanged();
            }
        }

        public int? MinAmount {
            get => _product.MinAmount;
            set {
                _product.MinAmount = value.Value;
                OnPropertyChanged();
            }
        }

        public int? MaxAmount {
            get => _product.MaxAmount;
            set {
                _product.MaxAmount = value.Value;
                OnPropertyChanged();
            }
        }

        public List<ProductGroups> ProductGroups {
            get => _productGroups;
            set {
                _productGroups = value;
                OnPropertyChanged();
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            // Validate required fields
            if (string.IsNullOrEmpty(PName) || string.IsNullOrEmpty(Code) || string.IsNullOrEmpty(Details)) {
                MessageBox.Show("Code and Name and Details are required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (Group == 0) {
                MessageBox.Show("Please select a Product Group.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try {
                if (_isNew) {
                    _dataModule.CreateRow(_product);
                } else {
                    _dataModule.UpdateRow(_product);
                }
                DialogResult = true;
                Close();
            } catch (Exception ex) {
                MessageBox.Show($"Error saving Product: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e) {
            DialogResult = false;
            Close();
        }
    }
}
