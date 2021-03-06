using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TripLog.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected BaseViewModel()
        {

        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public virtual void Init() { }
    }
    public class BaseViewModel<TParameter> : BaseViewModel
    {
        protected BaseViewModel()
        {
        }
        public override void Init()
        {
            Init(default(TParameter));
        }
        public virtual void Init(TParameter parameter)
        {
        }
    }
}