using CareerLead.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerLead.Domain.Test.Model
{
    public class MenteeTest
    {
        [Fact]
        void canCreateEmployee()
        {
            Employee mentee = Employee.BuildMentee();
            Assert.NotNull(mentee);
        }

        [Fact]
        void menteeHasEmptyMentor()
        {
            Mentee mentee = Employee.BuildMentee();
            Assert.Null(mentee.Mentor);
        }

        [Fact]
        void menteeHasMidSeniorityByDefault()
        {
            Mentee mentee = Employee.BuildMentee();
            Assert.Equal(Employee.Seniority.MID, mentee.Position);
        }

        [Fact]
        void menteeCanSubscribeToAMentor()
        {
            Mentee mentee = Employee.BuildMentee();
            Mentor mentor = Employee.BuildMentor();
            mentee.SubscribeToMentor(mentor);
            Assert.NotNull(mentee.Mentor);
        }

        [Fact]
        void mmenteeCanUnsubscribeFromItsMentor()
        {
            Mentee mentee = Employee.BuildMentee();
            Mentor mentor = Employee.BuildMentor();
            mentee.UnSubscribeToMentor(mentor);
            Assert.Null(mentee.Mentor);
        }
    }

  
}
