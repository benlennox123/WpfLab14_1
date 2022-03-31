using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLab14_1
{
    public enum ProductCategoryList
    {
        Food,
        HomeTechnique
    }

    public class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public ProductCategoryList ProductCategory { get; set; }
    }

    
}
