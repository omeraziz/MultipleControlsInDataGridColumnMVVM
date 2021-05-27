using ComboBoxMVVMExample.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxMVVMExample.ViewModel
{
    public class DynamicCascadingComboInGridViewModel : ViewModelBase
    {

        private ObservableCollection<DynamicCascadingComboInGridModel> _dynamicDataList;

        public ObservableCollection<DynamicCascadingComboInGridModel> DynamicDataList
        {
            get { return _dynamicDataList; }
            set
            {
                _dynamicDataList = value;
                OnPropertyChanged("DynamicDataList");
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


        private List<string> _states;
        public List<string> States
        {
            get { return _states; }
            set { _states = value; OnPropertyChanged("States"); }
        }

        private string _selectedState;
        public string SelectedState
        {
            get { return _selectedState; }
            set { _selectedState = value; OnPropertyChanged("SelectedState"); }
        }


        private List<string> _cities;
        public List<string> Cities
        {
            get { return _cities; }
            set { _cities = value; OnPropertyChanged("Cities"); }
        }

        private string _selectedCity;

        public string SelectedCity
        {
            get { return _selectedCity; }
            set { _selectedCity = value; OnPropertyChanged("SelectedCity"); }
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
        public DynamicCascadingComboInGridViewModel()
        {
            Countries = CountriesStatesCities.GetCountriesList();
            States = CountriesStatesCities.GetStatesList(Countries[0]);
            Cities = CountriesStatesCities.GetCitiesList(Countries[0]);
            var s = States.Count > 0 ? States[0] : string.Empty;
            var c = Cities.Count > 0 ? Cities[0] : string.Empty;


            DynamicDataList = new ObservableCollection<DynamicCascadingComboInGridModel>
            {
                new DynamicCascadingComboInGridModel("TextBox" , "TextBox Value", "Display Text 1"),
                new DynamicCascadingComboInGridModel("CheckBox" , "True", "Display Check 2"),
                new DynamicCascadingComboInGridModel("ComboBox" , Countries?[0], "Countries", Countries, "SelectedPropertyName"),
                new DynamicCascadingComboInGridModel("CheckBox" , "False", "Lock0"),
                new DynamicCascadingComboInGridModel("ComboBox" , States.Count > 0 ? States[0] : string.Empty, "States", States, "SelectedPropertyName"),
                new DynamicCascadingComboInGridModel("CheckBox" , "True", "Lock1"),
                new DynamicCascadingComboInGridModel("ComboBox" , Cities.Count > 0 ? Cities[0] : string.Empty, "Cities", Cities, "SelectedPropertyName")
            };
        }
    }
}
