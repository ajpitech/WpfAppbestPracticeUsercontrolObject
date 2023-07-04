
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;

namespace WpfAppbestPracticeUsercontrolObject
{
    public class BaseViewModel : INotifyPropertyChanged
    {

        public Object ListUC1 { get; set; } = new Object();
        public event PropertyChangedEventHandler PropertyChanged;
        public IList collectionList { get; set; }


        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}