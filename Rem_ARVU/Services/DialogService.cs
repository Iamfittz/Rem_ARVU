using Rem_ARVU.EditForms;
using Rem_ARVU.Rem_ARVUDataset;
using System.Windows;

namespace Rem_ARVU.Services {
    public class DialogService {
        private readonly DataModule _dataModule;
        public DialogService(DataModule dataModule) {
            _dataModule = dataModule;
        }

        public bool ShowCreateProductGroupDialog() {
            var form = new ProductGroupForm(_dataModule, new ProductGroups(), isNew: true);
            return form.ShowDialog() == true;
        }

        public bool ShowUpdateProductGroupDialog(ProductGroups productGroup) {
            if (productGroup == null) return false;

            var form = new ProductGroupForm(_dataModule, (ProductGroups)productGroup.Clone(), isNew: false);
            return form.ShowDialog() == true;
        }

        public bool ShowCreateVendorDialog() {
            var form = new VendorForm(_dataModule, new Vendors(), isNew: true);
            return form.ShowDialog() == true;
        }

        public bool ShowUpdateVendorDialog(Vendors vendor) {
            if (vendor == null) return false;

            var form = new VendorForm(_dataModule, (Vendors)vendor.Clone(), isNew: false);
            return form.ShowDialog() == true;
        }

        public bool ShowCreateProductDialog() {
            var form = new ProductForm(_dataModule, new Products(), isNew: true);
            return form.ShowDialog() == true;
        }

        public bool ShowUpdateProductDialog(Products product) {
            if (product == null) return false;

            var form = new ProductForm(_dataModule, (Products)product.Clone(), isNew: false);
            return form.ShowDialog() == true;
        }
        public bool ShowDeleteConfirmation(string itemName) {
            return MessageBox.Show(
                $"Delete '{itemName}'?",
                "Confirm Delete",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.Yes;
        }
    }
}