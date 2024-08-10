using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhar
{
    public class empmethod : employeerepo
    {
        public bool addemployee(employe employe)
        {
            employeemanagesystem employeemanagesystem = new employeemanagesystem();
            employeemanagesystem.employes.Add(employe);

            int v = employeemanagesystem.SaveChanges();
            if (v > 0)
            {
                Console.WriteLine("row add");
                return true;
            }
            else
            {
                Console.WriteLine("error");
                return false;
            }
        }
    }
}
