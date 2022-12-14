using System.Diagnostics;
using System.Text.RegularExpressions;

namespace DI_Demo.Models
{
    public class Employee
    {
        public int eId { get; set; }
        public string eName { get; set; }
        public string eDesigantion { get; set; }
        public double eSalary { get; set; }
        public bool eIsPermenant { get; set; }

       static List<Employee> eList = new List<Employee>()
        {
            new Employee(){ eId=101, eName="Karan", eDesigantion="Sales", eIsPermenant=true, eSalary=7000},
            new Employee(){ eId=102, eName="Karan", eDesigantion="Sales", eIsPermenant=true, eSalary=7000},
            new Employee(){ eId=103, eName="Karan", eDesigantion="Sales", eIsPermenant=true, eSalary=7000},
            new Employee(){ eId=104, eName="Karan", eDesigantion="Sales", eIsPermenant=true, eSalary=7000},
            new Employee(){ eId=105, eName="Karan", eDesigantion="Sales", eIsPermenant=true, eSalary=7000},
            new Employee(){ eId=106, eName="Karan", eDesigantion="Sales", eIsPermenant=true, eSalary=7000},
            new Employee(){ eId=107, eName="Karan", eDesigantion="Sales", eIsPermenant=true, eSalary=7000},
            new Employee(){ eId=108, eName="Karan", eDesigantion="Sales", eIsPermenant=true, eSalary=7000},
        };


        public List<Employee> GetALlEmployees()
        {
            return eList;   
        }

        public Employee GetEmpById(int id)
        {
            var em = eList.Find(e => e.eId == id);
            return em;
        }

        public List<Employee> GetEmpByDesigantion(string desigantion)
        {
            var em = eList.FindAll(e => e.eDesigantion == desigantion);
            return em;
        }







    };
}
