using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListOfProducts.ViewModels;
using Xamarin.Forms;

namespace ListOfProducts.Views
{
    public partial class ProductView : ContentPage
    {
        private ProductViewModel _viewModel;

        public ProductView(Product product)
        {
            InitializeComponent();
            BindingContext = _viewModel = new ProductViewModel(this, product);
        }
    }
}
