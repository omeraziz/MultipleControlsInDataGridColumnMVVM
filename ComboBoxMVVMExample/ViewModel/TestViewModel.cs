using ComboBoxMVVMExample.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxMVVMExample.ViewModel
{
    public class TestViewModel : ViewModelBase
    {

        private ObservableCollection<TestModel> _testDataList;

        public ObservableCollection<TestModel> TestDataList
        {
            get { return _testDataList; }
            set
            {
                _testDataList = value;
                OnPropertyChanged("TestDataList");
            }
        }

        //List<string> Countries = new List<string> { "Pakistan", "Bangladesh", "China", "Russia", "Turkey", "Australia", "Zimbabwe", "South Africa" };

        //List<string> Cities = new List<string> { "Lahore", "Jhelum", "Islamabad", "Faisalabad", "Karachi", "Queta"};

        private List<string> _countries;
        public List<string> Countries
        {
            get { return _countries; }
            set { _countries = value; OnPropertyChanged("Countries"); }
        }

        private string _selectedCountry;
        public string SelectedCountry
        {
            get { return _selectedCountry; }
            set { _selectedCountry = value; OnPropertyChanged("SelectedCountry"); }
        }


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
                System.Diagnostics.Trace.WriteLine("PropertyChanged SelectedPropertyName VM value: " + _selectedPropertyName);
            }
        }
        public TestViewModel()
        {
            Countries = CountriesStatesCities.GetCountriesList();

            TestDataList = new ObservableCollection<TestModel>
            {
                new TestModel("TextBox" , 21, true, Countries),
                new TestModel("CheckBox" , 23, false, Countries),
                new TestModel("ComboBox" , 25, true, Countries),
            };
        }
    }
}
