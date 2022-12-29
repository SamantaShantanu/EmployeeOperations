using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeOperations.DAL;

namespace EmployeeOperations.BLL
{
    public class EmployeeRegistrationSave
    {
        EmployeeSave objEmp = new EmployeeSave();

        public bool EmployeeRegistration(Employee emp)
        {
            if ((!string.IsNullOrEmpty(emp.Email)) && (!string.IsNullOrEmpty(emp.Password)))
            {
                if (objEmp.EmployeeRegistration(emp))
                    return true; 
            }
            return false;
        }
    }
}
