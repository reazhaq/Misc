using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListOfProducts.ViewModels;
using Xamarin.Forms;

namespace ListOfProducts.Views
{
    public partial class ProductsView2 : ContentPage
    {
        private ProductsView2Model _viewModel;
        public ProductsView2()
        {
            InitializeComponent();
            //Xamarin.Insights.Track("Home");
            BindingContext = _viewModel = new ProductsView2Model(this);

            ListOfProducts.ItemTapped += (sender, eventData) =>
            {
                var tappedItem = eventData.Item;
                if (tappedItem is Product)
                {
                    var tappedProduct = (Product) tappedItem;
                    Debug.WriteLine(tappedProduct.Name);
                    Navigation.PushAsync(new ProductView(tappedProduct));
                }
                ((ListView) sender).SelectedItem = null;
            };
        }
        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    if (_viewModel.Products.Count > 0 || _viewModel.IsBusy)
        //        return;

        //    //_viewModel.GetProductsCommand.Execute(null);
        //    //_viewModel.Products;
        //}
    }
}
