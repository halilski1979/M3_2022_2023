using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_w_Problem3_Employe
{
    public class Employe
    {
        private string name;
        private double salary;
        private string email;
        private string position;
        private string department;
        private int age;
       
        
        //Име
        public string Name
        {
            get { return name; }
            set { name = value; }
        }        

        //Заплата
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }      

        // Длъжност     
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        // Отдел     
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        // Електронна поща      
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        
        // Възраст      
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return $"{Name} {Salary:F2} {Email} {Age}";
        }

    }
}
