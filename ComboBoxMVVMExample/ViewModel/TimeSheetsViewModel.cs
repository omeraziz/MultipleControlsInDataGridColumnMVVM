using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxMVVMExample.ViewModel
{


    public class TimeSheetsViewModel
    {
        public ObservableCollection<Time> Times { get; set; }
        public ObservableCollection<Department> Departments { get; set; }
        public ObservableCollection<string> JobCodes { get; set; }

        public TimeSheetsViewModel()
        {
            Departments = new ObservableCollection<Department>();
            GetDepartments();

            JobCodes = new ObservableCollection<string>();
            GetJobCodes();

            Times = new ObservableCollection<Time>();
            GetTimes();
        }

        private void GetJobCodes()
        {
            JobCodes = new ObservableCollection<string> { "01-A", "01-B", "01-C", "02-A", "02-B", "02-C", "03-A", "03-B", "03-C", "03-E", "04-A", "04-B", "04-C", };
        }

        private void GetDepartments()
        {
            Departments = new ObservableCollection<Department> {
            new Department("01"),
            new Department("02"),
            new Department("03"),
            new Department("04")
        };
        }

        private void GetTimes()
        {
            Times = new ObservableCollection<Time> {
            new Time(Departments[0], JobCodes[0]),
            new Time(Departments[0], JobCodes[1]),
            new Time(Departments[0], JobCodes[2]),
            new Time(Departments[0], JobCodes[2]),
            new Time(Departments[0], JobCodes[2]),
            new Time(Departments[1], JobCodes[3]),
            new Time(Departments[1], JobCodes[3]),
            new Time(Departments[1], JobCodes[4]),
            new Time(Departments[1], JobCodes[4]),
            new Time(Departments[2], JobCodes[6]),
            new Time(Departments[2], JobCodes[6]),
            new Time(Departments[2], JobCodes[7]),
            new Time(Departments[3], JobCodes[3]),
            new Time(Departments[3], JobCodes[11]),
            new Time(Departments[3], JobCodes[12]),
            new Time(Departments[3], JobCodes[11])
        };
        }
    }

    public class Department
    {
        public String DepartmentCode { get; set; }
        public Department(string departmentCode) { DepartmentCode = departmentCode; }
    }

    public class Time
    {
        //time in etc etc
        public Department Department { get; set; }
        public string Job { get; set; }

        public Time(Department d, String job)
        {
            Department = d;
            Job = job;
        }
    }

#if false

    class TimeSheetsViewModel
    {

        public ObservableCollection<MyTime> MyTimes { get; set; }
        public ObservableCollection<Department> Departments { get; set; }

        public TimeSheetsViewModel()
        {
            MyTimes = new ObservableCollection<MyTime>();
            Departments = new ObservableCollection<Department>();
            GetDepartments();
        }

        private void GetDepartments()
        {
            /*
             This section contains code to connect to my SQL Database and fills a DataTable dt
            */

            if (Departments != null)
                Departments.Clear();


            for (int i = 0; i < 12; i++)
            {
                Department d = new Department() { Display = "DISPLAY_"+i.ToString(), DepartmentCode = "DEPARTMENT_CODE_" + i.ToString(), CompanyCode = "COMPANY_CODE_" + i.ToString() };
                Departments.Add(d);
            }

            for (int i = 0; i < 40; i++)
            {
                MyTime t = new MyTime() { InTime = "INTIME_" + i.ToString(), OutTime = "OUTTIME_" + i.ToString(), Date = "DATE_" + i.ToString(), Hours="HOURS_"+i.ToString(), Department=Departments[i%12] };
                MyTimes.Add(t);
            }
        }
    }

    public class Department
    {
        public string Display { get; set; }
        public string DepartmentCode { get; set; }

        public string CompanyCode { get; set; }
    }


    public class MyTime
    {
        public string InTime { get; set; }
        public string OutTime { get; set; }

        public string Date { get; set; }

        public string Hours { get; set; }

        public Department Department;

    }
#endif
}
