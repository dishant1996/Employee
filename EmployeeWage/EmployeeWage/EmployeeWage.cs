using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWage
    {
        public static void main(string[] args)
        {


            //constant

            int fulltime = 1;
            int empwage = 25;
            //variables

            int workHrs = 0;
            int workWage = 0;
            Random random = new Random();
            // computation

            int check = random.Next(0, 2);
            if (check == fulltime)
            {
                workHrs = 8;
            }
            else
            {
                workHrs = 0;
            }
            workWage = workHrs * empwage;
            Console.WriteLine("Salary : " + empwage);
            


        }
    }
}

