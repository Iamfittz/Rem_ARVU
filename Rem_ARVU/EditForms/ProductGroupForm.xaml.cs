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
