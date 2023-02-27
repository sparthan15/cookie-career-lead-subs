using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerLead.Domain.Model
{
    public interface Publisher
    {
        void Subscribe(Subscriber subscriber);
        void UnSubscribe(Subscriber subscriber);
        void NotifySubscribers();
    }
}
