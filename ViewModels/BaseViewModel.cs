﻿    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;

    namespace PM2Parcial3.ViewModels
    {
        public class BaseViewModel: INotifyPropertyChanged
        {
        
            public event PropertyChangedEventHandler? PropertyChanged;

            protected void OnPropertyChanged([CallerMemberName]string propertyName="")
            {
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
            }
            protected bool SetProperty<T>(ref T storage,T value, [CallerMemberName] string propertyName = null)
            {
                if(object.Equals(storage,value)) return false;
                storage = value;
                OnPropertyChanged(propertyName);
                return true;
            }
        }
    }
