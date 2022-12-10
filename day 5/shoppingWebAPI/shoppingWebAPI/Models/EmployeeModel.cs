namespace shoppingWebAPI.Models
{
    public class EmployeeModel
    {
        public int eId{ get; set; }
        public string eName { get; set; }
        public string eDesignation { get; set; }
        public double eSalary { get; set; }
        public bool eIsPermenant { get; set; }
        public string eEmail { get; set; }

        static List<EmployeeModel> eList = new List<EmployeeModel>()
        {
            new EmployeeModel(){ eId=101, eName="Karan", eDesignation="Sales", eEmail="karan@gmail.com", eIsPermenant=true, eSalary=5000},
            new EmployeeModel(){ eId=102, eName="Rahul", eDesignation="HR", eEmail="karan@gmail.com", eIsPermenant=true, eSalary=6000},
            new EmployeeModel(){ eId=103, eName="Mohan", eDesignation="Sales", eEmail="karan@gmail.com", eIsPermenant=false, eSalary=7000},
            new EmployeeModel(){ eId=104, eName="Kiran", eDesignation="Accounts", eEmail="karan@gmail.com", eIsPermenant=true, eSalary=8000},
            new EmployeeModel(){ eId=105, eName="Ram", eDesignation="Sales", eEmail="karan@gmail.com", eIsPermenant=true, eSalary=15000},
            new EmployeeModel(){ eId=106, eName="Shyam", eDesignation="Accounts", eEmail="karan@gmail.com", eIsPermenant=true, eSalary=45000},
            new EmployeeModel(){ eId=107, eName="Amit", eDesignation="Sales", eEmail="karan@gmail.com", eIsPermenant=false, eSalary=3000},
        };

        #region Get Methods
        public List<EmployeeModel> GetAllEmployees()
        {
            return eList;
        }

        public EmployeeModel GetEmployeeById(int id)
        {
            var emp = eList.Find(em => em.eId == id);
            if (emp != null)
            {
                return emp;
            }
            throw new Exception("Employee not found");
        }

        public List<EmployeeModel> GetEmployeeByStatus(bool ispermenant)
        {
            var em = eList.FindAll(emp => emp.eIsPermenant == ispermenant);
            if (em!=null)
            {
                return em;
            }
            throw new Exception("No Employee found working as unknown status ");
        }

        public List<EmployeeModel> GetEmployeeBydesignation(string designation)
        {
            var em = eList.FindAll(emp => emp.eDesignation == designation);
            if (em.Count > 0)
            {
                return em;
            }
            throw new Exception("No Employee Found working as " + designation);
        }

        public double GetTotalSalaryPaid()
        {
            var total = eList.Sum(em => em.eSalary);
            return total;
        }
        #endregion

        public string AddEmployee(EmployeeModel newEmp)
        {
            if (newEmp.eId < 0)
            {
                throw new Exception("Please enter valid positive Employee Number");
            }
            //do all the validations before adding

            eList.Add(newEmp);
            return "Employee Added sussessfully";

        }

        public string DeleteEmployee(int id)
        {
            var emp = eList.Find(em => em.eId == id);
            eList.Remove(emp);
            return "Employee Deleted Successfully";
        }

        public string updateEmployee(EmployeeModel changes)
        {
            var emp = eList.Find(em => em.eId == changes.eId);
            emp.eName = changes.eName;
            emp.eDesignation = changes.eDesignation;
            emp.eSalary = changes.eSalary;
            emp.eIsPermenant = changes.eIsPermenant;

            return "Employee Details modified successfully";
        }
    }
}
