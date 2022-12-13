namespace partial_view.Models
{
    public class Employee
    {
        public int eId { get; set; }
        public string eName { get; set; }
        public string eDesigantion { get; set; }
        public double eSalary { get; set; }
        public bool eIsPermenant { get; set; }

      static  List<Employee> eList = new List<Employee>()
        {
            new Employee(){ eId=101, eName="Nikhil", eDesigantion="Sales", eIsPermenant=true, eSalary=2000},
            new Employee(){ eId=102, eName="Rahul", eDesigantion="HR", eIsPermenant=true, eSalary=2000},
            new Employee(){ eId=103, eName="Karan", eDesigantion="Sales", eIsPermenant=false, eSalary=2000},
            new Employee(){ eId=104, eName="Sohail", eDesigantion="HR", eIsPermenant=true, eSalary=2000}
        };


        public List<Employee> GetEmpList()
        {
            return eList;
        }

        public string AddEmployee(Employee newEmp)
        {

            eList.Add(newEmp);
            return "Employee Added Successfully";

        }





    }
}
