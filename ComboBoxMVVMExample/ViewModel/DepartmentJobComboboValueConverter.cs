using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ComboBoxMVVMExample.ViewModel
{
    public class DepartmentJobComboboValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            Department department = values[0] as Department;
            ObservableCollection<string> jobCodes = values[1] as ObservableCollection<string>;

            //do our logic to filter the job codes by department
            return jobCodes.Where(jobCode => jobCode.StartsWith(department.DepartmentCode)).ToList();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
