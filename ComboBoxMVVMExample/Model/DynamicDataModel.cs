using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxMVVMExample.Model
{
    public class DynamicDataModel
    {
        public string DisplayAs { get; set; } // TextBox, CheckBox, ComboBox
        public string Value { get; set; }
        public string DisplayName { get; set; } // Row1, Row2, ...

        public DynamicDataModel(string displayAs, string val, string displayName)
        {
            DisplayAs = displayAs;
            Value = val;
            DisplayName = displayName;
        }
    }
}
