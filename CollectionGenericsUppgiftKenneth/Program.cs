using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionGenericsUppgiftKenneth
{
    class Program: Employee
    {
        static void Main(string[] args)
        {
            
            //Del1
            Employee E1 = new Employee(){EmployeeId = 1101, EmployeeName = "Bell", EmployeeGender = "Female", EmployeeSalary = 30400};
            Employee E2 = new Employee(){EmployeeId = 1102, EmployeeName = "Liam", EmployeeGender = "Male", EmployeeSalary = 20003};
            Employee E3 = new Employee(){EmployeeId = 1103, EmployeeName = "Kenneth", EmployeeGender = "Male", EmployeeSalary = 10000};
            Employee E4 = new Employee(){EmployeeId = 1104, EmployeeName = "Emelie", EmployeeGender = "Female", EmployeeSalary = 25000};
            Employee E5 = new Employee(){EmployeeId = 1105, EmployeeName = "Robin", EmployeeGender = "Male", EmployeeSalary = 15000};
            Stack<Employee> EmpStack = new Stack<Employee>();
            EmpStack.Push(E1);
            EmpStack.Push(E2);
            EmpStack.Push(E3);
            EmpStack.Push(E4);
            EmpStack.Push(E5);
            

            foreach (Employee item in EmpStack)
            {
                Console.WriteLine("Det är {0} personer kvar i stacken", EmpStack.Count);
                
                Console.WriteLine("Employee ID: {0} -, Name: {1} -, Gender: {2} - Salary: {3}", item.EmployeeId, item.EmployeeName, item.EmployeeGender, item.EmployeeSalary);
                
            }
            Console.WriteLine("---------------------------------------");
            foreach (Employee item in EmpStack.ToList())
            {
                Employee EmpPop = EmpStack.Pop();
                Console.WriteLine("Det är {0} personer kvar i stacken", EmpStack.Count);

                Console.WriteLine("Employee ID: {0} -, Name: {1} -, Gender: {2} - Salary: {3}", EmpPop.EmployeeId, EmpPop.EmployeeName, EmpPop.EmployeeGender, EmpPop.EmployeeSalary);
                
            }
            EmpStack.Push(E1);
            EmpStack.Push(E2);
            EmpStack.Push(E3);
            EmpStack.Push(E4);
            EmpStack.Push(E5);
            Console.WriteLine("----------------------------");
            Employee EmpPeek = EmpStack.Peek();
            Console.WriteLine("Employee ID: {0} -, Name: {1} -, Gender: {2} - Salary: {3}", EmpPeek.EmployeeId, EmpPeek.EmployeeName,EmpPeek.EmployeeGender,EmpPeek.EmployeeSalary);
            Console.WriteLine("Det är {0} personer kvar i stacken", EmpStack.Count);
            Console.WriteLine("Employee ID: {0} -, Name: {1} -, Gender: {2} - Salary: {3}", EmpPeek.EmployeeId, EmpPeek.EmployeeName, EmpPeek.EmployeeGender, EmpPeek.EmployeeSalary);
            Console.WriteLine("Det är {0} personer kvar i stacken", EmpStack.Count);
            if (EmpStack.Contains(E3))
            {
                Console.WriteLine("E3 is in stack");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            //----------------------------------------------------------------------------------------------------------------------
            //Del 2
            List<Employee> EmpList = new List<Employee>();

            EmpList.Add(E1);
            EmpList.Add(E2);
            EmpList.Add(E3);
            EmpList.Add(E4);
            EmpList.Add(E5);
            Employee FindEmp = EmpList.Find(x => x.EmployeeGender.Contains("Male"));
            //Employee FindAllEmp = EmpList.FindAll(x => x.EmployeeGender.Contains("Male"));
            List<Employee> FindAllEmp = EmpList.FindAll(x => x.EmployeeGender.Contains("Male"));

            if (EmpList.Contains(E2))
            {
                Console.WriteLine("Employee 2 exist in list");
                Console.WriteLine("---------------------------------------");
            }
            
            Console.WriteLine("Employee ID: {0} -, Name: {1} -, Gender: {2} - Salary: {3}", FindEmp.EmployeeId, FindEmp.EmployeeName, FindEmp.EmployeeGender, FindEmp.EmployeeSalary);
            Console.WriteLine("--------------------------------");

            foreach (Employee item in FindAllEmp)
            {
                Console.WriteLine("Employee ID: {0} - Name: {1} -, Gender: {2} - Salary: {3}",item.EmployeeId, item.EmployeeName, item.EmployeeGender, item.EmployeeSalary);
            }

        }
    }
}
