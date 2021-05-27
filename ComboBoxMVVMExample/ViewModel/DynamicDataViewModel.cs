using ComboBoxMVVMExample.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxMVVMExample.ViewModel
{
    public class DynamicDataViewModel : ViewModelBase
    {

        private ObservableCollection<DynamicDataModel> _dynamicDataList;

        public ObservableCollection<DynamicDataModel> DynamicDataList
        {
            get { return _dynamicDataList; }
            set { _dynamicDataList = value;
                OnPropertyChanged("DynamicDataList");
            }
        }


        public DynamicDataViewModel()
        {
            DynamicDataList = new ObservableCollection<DynamicDataModel>
            {
                new DynamicDataModel("TextBox" , "TextBox Value", "Display Text 1"),
                new DynamicDataModel("CheckBox" , "CheckBox Value", "Display Check 1"),
                new DynamicDataModel("ComboBox" , "ComboBox Value", "Display Combo 1"),
            };
        }
    }
}
