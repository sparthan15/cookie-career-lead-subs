using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerLead.Domain.Model
{
    public class Employee
    {
        public Seniority Position {get;}

        public static Mentee BuildMentee()
        {
            return new Mentee();
        }

        public static Mentor BuildMentor()
        {
            return new Mentor();
        }

       public enum Seniority
        {
            MID, 
            SENIOR, 
            ADNVANCED
        }
    }
    

}
