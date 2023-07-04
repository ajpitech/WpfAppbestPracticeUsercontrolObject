using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppbestPracticeUsercontrolObject
{
    public class MainWindowViewModel : BaseViewModel
    {
        public GenericDisplay Products { get; set; }
        public GenericDisplay Users { get; set; }

        public MainWindowViewModel()
        {

            Products = new SearchableProducts(new List<object>() {
                new Product() { Brand = "Apple",Name = "Iphone" },
                new Product() { Brand = "Apple",Name = "IPad" },
            });
            Users = new GenericDisplay(new List<object>() { "Admin", "Guest", "Manager" });

        }
    }

}
