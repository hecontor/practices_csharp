using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.hackerrank
{
    internal class HRListOfEmployees
    {
        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            // Creamos un diccionario para almacenar las edades promedio de cada compañía
            Dictionary<string, int> averageAgePerCompany = new Dictionary<string, int>();

            // Agrupamos los empleados por compañía
            var groupedEmployees = employees.GroupBy(emp => emp.Company);

            // Iteramos sobre cada grupo de empleados por compañía
            foreach (var group in groupedEmployees)
            {
                // Calculamos el promedio de edad para el grupo actual
                int averageAge = (int)Math.Round(group.Average(emp => emp.Age));

                // Almacenamos el promedio de edad en el diccionario
                averageAgePerCompany.Add(group.Key, averageAge);
            }

            // Ordenamos el diccionario por compañía
            averageAgePerCompany = averageAgePerCompany.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            return averageAgePerCompany;
        }
        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            // Creamos un diccionario para almacenar la cantidad de empleados por cada compañía
            Dictionary<string, int> countOfEmployeesPerCompany = new Dictionary<string, int>();

            // Agrupamos los empleados por compañía y contamos el número de empleados en cada grupo
            var groupedEmployees = employees.GroupBy(emp => emp.Company);
            foreach (var group in groupedEmployees)
            {
                countOfEmployeesPerCompany.Add(group.Key, group.Count());
            }

            // Ordenamos el diccionario por compañía
            countOfEmployeesPerCompany = countOfEmployeesPerCompany.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            return countOfEmployeesPerCompany;
        }
        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            // Creamos un diccionario para almacenar el empleado más viejo por cada compañía
            Dictionary<string, Employee> oldestEmployeePerCompany = new Dictionary<string, Employee>();

            // Agrupamos los empleados por compañía y encontramos el empleado más viejo en cada grupo
            var groupedEmployees = employees.GroupBy(emp => emp.Company);
            foreach (var group in groupedEmployees)
            {
                var oldestEmployee = group.OrderByDescending(emp => emp.Age).First();
                oldestEmployeePerCompany.Add(group.Key, oldestEmployee);
            }
            oldestEmployeePerCompany = oldestEmployeePerCompany.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
                
            return oldestEmployeePerCompany;
        }
    }

    public class Employee {
       
        public string FirstName;
        public string LastName;
        public string Company;
        public int Age;
        public Employee(string FirstName,string LastName, string Company, int Age) { 
        
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Company = Company;
            this.Age = Age;
        }
    }
}
