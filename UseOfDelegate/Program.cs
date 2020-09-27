using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Priya",
                Gender = "Female",
                Experience = 2,
                Salary = 5000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Experience = 10,
                Salary = 20000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Gender = "Male",
                Experience = 15,
                Salary = 30000
            };
            List<Employee> lstEmployess = new List<Employee>();
            lstEmployess.Add(emp1);
            lstEmployess.Add(emp2);
            lstEmployess.Add(emp3);


            Console.WriteLine("On which condition based you want to promote employees ?");
            Console.WriteLine("Type 1 for Salary more then 10000.");
            Console.WriteLine("Type 2 for Exprence more then 5 years.");
            Console.WriteLine("Type 3 for haveing Male Gender.");
            string getString = Console.ReadLine();
            EligibleToPromotion eligibleToPromotion;
            if (getString == "1")
            {
                Console.WriteLine("Promoted based on PromoteBySal");
                eligibleToPromotion = new EligibleToPromotion(Employee.PromoteBySal);
                Employee.PromoteEmployee(lstEmployess, eligibleToPromotion);

                Console.WriteLine("By using Lambda expressions");
                Console.WriteLine("Promoted based on PromoteBySal");
                Employee.PromoteEmployee(lstEmployess, col => col.Salary > 10000);
            }
            else if(getString=="2")
            {
                Console.WriteLine("Promoted based on PromoteByExp");
                eligibleToPromotion = new EligibleToPromotion(Employee.PromoteByExp);
                Employee.PromoteEmployee(lstEmployess, eligibleToPromotion);

                Console.WriteLine("By using Lambda expressions");
                Console.WriteLine("Promoted based on PromoteByExp");
                Employee.PromoteEmployee(lstEmployess, col => col.Experience > 5);
            }
            else if(getString=="3")
            {
                Console.WriteLine("Promoted based on PromoteByGender");
                eligibleToPromotion = new EligibleToPromotion(Employee.PromoteByGender);
                Employee.PromoteEmployee(lstEmployess, eligibleToPromotion);

                Console.WriteLine("By using Lambda expressions");
                Console.WriteLine("Promoted based on PromoteByGender");
                Employee.PromoteEmployee(lstEmployess, col => col.Gender == "Male");
            }
            else
            {
                Console.WriteLine("Only understand 1, 2, 3 number.");
            }
            Console.ReadKey();

        }
    }
}
