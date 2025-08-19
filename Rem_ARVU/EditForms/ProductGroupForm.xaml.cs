using Rem_ARVU.Rem_ARVUDataset;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Rem_ARVU.EditForms {
    /// <summary>
    /// Interaction logic for ProductGroupForm.xaml
    /// </summary>
    public partial class ProductGroupForm : Window, INotifyPropertyChanged {
        private readonly ProductGroups _productGroup;
        private readonly bool _isNew;
        private readonly DataModule _dataModule;
        public ProductGroupForm(DataModule dataModule, ProductGroups productGroup, bool isNew) {
            InitializeComponent();
            DataContext = this;
            _productGroup = productGroup;
            _isNew = isNew;
            _dataModule = dataModule;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string PGName {
            get => _productGroup.Name;
            set {
                _productGroup.Name = value;
                OnPropertyChanged();
            }
        }

        public int? PGParent {
            get => _productGroup.Parent;
            set {
                _productGroup.Parent = value;
                OnPropertyChanged();
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(PGName)) {
                MessageBox.Show("Name is required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try {
                // Save changes using DataModule
                if (_isNew) {
                    _dataModule.CreateRow(_productGroup);
                } else {
                    _dataModule.UpdateRow(_productGroup);
                }
                DialogResult = true;
                Close();
            } catch (Exception ex) {
                MessageBox.Show($"Error saving Product Group: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e) {
            DialogResult = false;
            Close();
        }
    }
}
