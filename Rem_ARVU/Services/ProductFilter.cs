using Rem_ARVU.Rem_ARVUDataset;
using System.Collections.Generic;
using System.Linq;

namespace Rem_ARVU.Services {
    public class ProductFilter {
        public List<Products> FilterByProductGroup(List<Products> products, ProductGroups selectedGroup) {
            if (products == null || selectedGroup == null)
                return new List<Products>();

            return products.Where(p => p.Group == selectedGroup.Id).ToList();
        }

        public List<Products> FilterByVendor(List<Products> products, Vendors selectedVendor) {
            if (products == null || selectedVendor == null)
                return new List<Products>();

            return products.Where(p => p.Vendor == selectedVendor.Id).ToList();
        }

        public List<Products> GetFilteredProducts(List<Products> products, ProductGroups selectedGroup, Vendors selectedVendor) {
            if (products == null)
                return new List<Products>();

            if (selectedGroup != null)
                return FilterByProductGroup(products, selectedGroup);

            if (selectedVendor != null)
                return FilterByVendor(products, selectedVendor);

            return new List<Products>(products);
        }
    }
}