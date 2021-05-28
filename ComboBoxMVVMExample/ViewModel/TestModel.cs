using System.Collections.Generic;

namespace ComboBoxMVVMExample.ViewModel
{
    public class TestModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Active { get; set; }
        public List<string> Countries { get; set; }
        public string SelectedVal { get; set; }

        public TestModel(string name, int age, bool active, List<string> countries)
        {
            this.Name = name;
            this.Age = age;
            this.Active = active;
            this.Countries = countries;
            this.SelectedVal = Countries.Count > 0 ? Countries[0] : "";
        }
    }
}