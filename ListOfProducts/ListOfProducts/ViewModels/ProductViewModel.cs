using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListOfProducts.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {

        public string MainText
        {
            get { return "ProductMainText"; }
        }

        public Product Product { get; set; }

        public ProductViewModel(Page page, Product product) : base(page)
        {
            Product = product;
        }
    }
}
