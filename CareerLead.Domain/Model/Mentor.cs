using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerLead.Domain.Model
{
    public class Mentor : Employee, Publisher
    {
        public List<Subscriber> Mentees { get; }

        public Mentor()
        {
            Mentees = new List<Subscriber>();
        }

        public static Mentor BuildEmpty()
        {
            return new Mentor();
        }


        public void Subscribe(Subscriber subscriber)
        {
            Mentees.Add(subscriber);
        }

        public void UnSubscribe(Subscriber subscriber)
        {
            Mentees.Remove(subscriber);
        }

        public void NotifySubscribers()
        {
            Mentees.ForEach(m => m.Update());
        }
    }
}
