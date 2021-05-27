using ComboBoxMVVMExample.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxMVVMExample.Model
{
    public class DynamicCascadingComboInGridModel : ViewModelBase
    {
        public string DisplayAs { get; set; } // TextBox, CheckBox, ComboBox

        private string _value;

        public string Value
        {
            get { return _value; }
            set 
            {
                _value = value;
                OnPropertyChanged("Value"); 
                System.Diagnostics.Trace.WriteLine("PropertyChanged Value M value: " + _value);
            }
        }

        //public string Value { get; set; }
        public string DisplayName { get; set; } // Row1, Row2, ...

        public List<string> StringList { get; set; } // For any control that takes a list as data e.g. ComboBox 

        //string SelectedPropertyName { get; set; } // Name of property which is changed when a value is selected in ComboBox

        private string _selectedPropertyName;

        public string SelectedPropertyName
        {
            get 
            {
                return _selectedPropertyName; 
            }
            set
            {
                _selectedPropertyName = value;
                OnPropertyChanged("SelectedPropertyName");
                System.Diagnostics.Trace.WriteLine("PropertyChanged SelectedPropertyName M value: " + _selectedPropertyName);
            }
        }


        public DynamicCascadingComboInGridModel(string displayAs, string val, string displayName, List<string> list = null, string selectedPropertyName = "")
        {
            DisplayAs = displayAs;
            Value = val;
            DisplayName = displayName;
            StringList = list;
            SelectedPropertyName = selectedPropertyName;
        }
    }
}
