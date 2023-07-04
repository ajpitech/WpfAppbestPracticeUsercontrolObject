using System.Collections.Generic;

namespace WpfAppbestPracticeUsercontrolObject
{
    internal class SearchableProducts : GenericDisplay
    {
        public SearchableProducts(List<object> items) : base(items)
        {
        }

        protected override string DisplayThing(object item)
        {
            Product p = (Product)item;
            return p.Name;
        }

        protected override bool Validate(object item)
        {
            Product p = (Product)item;
            return p?.Name.ToLower().Contains(SearchText?.ToLower() ?? "") ?? false;
        }
    }
}