using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSfDataGrid.Core
{
    public class INotify:INotifyPropertyChanged
    {
        #region Implementacion  INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChange(string property) {
            if(PropertyChanged != null) {
                PropertyChanged(this,new PropertyChangedEventArgs(property));
            }
        }
        #endregion
    }
}
