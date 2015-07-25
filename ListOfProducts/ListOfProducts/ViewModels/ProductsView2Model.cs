using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ListOfProducts.ViewModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    public class Grouping<K, T> : ObservableCollection<T>
    {
        public K Key { get; private set; }

        public Grouping(K key, IEnumerable<T> items)
        {
            Key = key;
            foreach (var item in items)
                this.Items.Add(item);
        }
    }

    public class ProductsView2Model : BaseViewModel
    {
        //readonly IDataProduct dataProduct;
        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<Grouping<string, Product>> ProductsGrouped { get; set; }

        public string Intro { get { return "Intro"; } }
        public string Summary { get { return "Summary"; } }


        public ProductsView2Model(Page page) : base(page)
        {
            Title = "Products View 2";
            //dataProduct = DependencyService.Get<IDataProduct>();
            Products = new ObservableCollection<Product>{
                new Product {Id=1, Name = "foo", Price = 1.00m},
                new Product {Id=2, Name = "bar", Price = 2.00m},
                new Product {Id=3, Name = "moo", Price = 3.00m}
            };
            ProductsGrouped = new ObservableCollection<Grouping<string, Product>>();
        }

        //public Command GetProductsCommand
        //{
        //    get
        //    {
        //        return Products;
        //        //    return getProductsCommand ??
        //        //        (getProductsCommand = new Command(async () => await ExecuteGetProductsCommand(), () => { return !IsBusy; }));
        //    }
        //}
    }
}