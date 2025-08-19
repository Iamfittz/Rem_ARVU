using Rem_ARVU.Rem_ARVUDataset;
using System.Collections.Generic;

namespace Rem_ARVU.Services {
    public class DataService {
        private readonly DataModule _dataModule;

        public DataService(DataModule dataModule) {
            _dataModule = dataModule;
        }

        #region ProductGroups
        public List<ProductGroups> GetProductGroups() {
            return _dataModule.GetItems<ProductGroups>() ?? new List<ProductGroups>();
        }

        public void DeleteProductGroup(ProductGroups productGroup) {
            _dataModule.DeleteRow(productGroup);
        }
        #endregion

        #region Vendors
        public List<Vendors> GetVendors() {
            return _dataModule.GetItems<Vendors>() ?? new List<Vendors>();
        }

        public void DeleteVendor(Vendors vendor) {
            _dataModule.DeleteRow(vendor);
        }
        #endregion

        #region Products
        public List<Products> GetProducts() {
            return _dataModule.GetItems<Products>() ?? new List<Products>();
        }

        public void DeleteProduct(Products product) {
            _dataModule.DeleteRow(product);
        }
        #endregion
    }
}