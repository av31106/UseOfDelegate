using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfDelegate
{
    public delegate bool EligibleToPromotion(Employee employeeToPromotion);
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        public static void PromoteEmployee(List<Employee> lstEmployees, EligibleToPromotion IsEmployeeEligible)
        {
            foreach (Employee employee in lstEmployees)
            {
                if (IsEmployeeEligible(employee))
                {
                    Console.WriteLine("Employee {0} Promoted", employee.Name);
                }
            }
        }

        public static bool PromoteBySal(Employee employee)
        {
            if (employee.Salary > 10000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool PromoteByExp(Employee employee)
        {
            if (employee.Experience > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool PromoteByGender(Employee employee)
        {
            if (employee.Gender == "Male")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
