using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerLead.Domain.Model
{
    public class Mentee : Employee, Subscriber
    {
        new public Mentor Mentor { get; set; }

        public void SubscribeToMentor(Mentor _mentor)
        {
            Mentor = _mentor;
        }
        public void UnSubscribeToMentor(Mentor _mentor)
        {
            Mentor = null;
        }

        public void Update()
        {
            Console.WriteLine("Got updated !");
        }
    }
}
