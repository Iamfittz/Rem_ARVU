using Rem_ARVU.Rem_ARVUDataset;
using System;
using System.Windows;

namespace Rem_ARVU.EditForms {
    public partial class VendorForm : Window {
        private readonly DataModule _dataModule;
        private readonly Vendors _vendor;
        private readonly bool _isNew;
        public VendorForm(DataModule dataModule, Vendors vendor, bool isNew) {
            InitializeComponent();
            _dataModule = dataModule ?? throw new ArgumentNullException(nameof(dataModule));
            _vendor = vendor ?? throw new ArgumentNullException(nameof(vendor));
            _isNew = isNew;
            LoadData();
        }
        private void LoadData() {
            CodeTextBox.Text = _vendor.Code;
            NameTextBox.Text = _vendor.Name;
            SiteTextBox.Text = _vendor.VendorSite;
        }
        private void SaveData() {
            _vendor.Code = CodeTextBox.Text;
            _vendor.Name = NameTextBox.Text;
            _vendor.VendorSite = SiteTextBox.Text;
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(CodeTextBox.Text)) {
                MessageBox.Show("Code is required!");
                return;
            }
            if (string.IsNullOrEmpty(NameTextBox.Text)) {
                MessageBox.Show("Name is required!");
                return;
            }
            try {
                SaveData();

                if (_isNew) {
                    _dataModule.CreateRow(_vendor);
                } else {
                    _dataModule.UpdateRow(_vendor);
                }

                DialogResult = true;
                Close();
            } catch (Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e) {
            DialogResult = false;
            Close();
        }
    }
}