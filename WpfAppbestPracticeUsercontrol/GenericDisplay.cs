using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Xml.Linq;

namespace WpfAppbestPracticeUsercontrolObject
{
    public class GenericDisplay : BaseViewModel
    {
        public ObservableCollection<string> ListUC { get; set; }
        private ObservableCollection<object> MainList { get; set; }



        private string _searchText { get; set; }
        public string SearchText
        {
            get
            {
                return _searchText;
            }
            set
            {
                _searchText = value;
                OnPropertyChanged(nameof(ListUC));
                Change();
            }
        }

        private void Change()
        {
            ListUC = new ObservableCollection<string>();
            foreach (var item in MainList)
            {
                if (Validate(item))
                {
                    ListUC.Add(DisplayThing(item));
                }
            }
            OnPropertyChanged(nameof(ListUC));
        }

        protected virtual string DisplayThing(object item)
        {
            return item.ToString();
        }

        protected virtual bool Validate(object item)
        {
            return item.ToString().ToLower().Contains(SearchText?.ToLower() ?? "");
        }

        public GenericDisplay(List<object> items)
        {
            MainList = new ObservableCollection<object>(items);
            Change();
        }
    }
}
