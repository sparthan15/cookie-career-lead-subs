using CareerLead.Domain.Model;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerLead.Domain.Test.Model
{
    public class MentorTest
    {
        [Fact]
        void canCreateMentor()
        {
            Mentor mentor = Employee.BuildMentor();
            Assert.NotNull(mentor);
        }

        [Fact]
        void canCreateEmptyMentor()
        {
            Mentor emptyMentor = Mentor.BuildEmpty();
            Assert.NotNull(emptyMentor);
        }
        [Fact]
        void mentorHasEmptyMenteesByDefault()
        {
            Mentor mentor = Employee.BuildMentor();
            Assert.Empty(mentor.Mentees);
        }

        [Fact]
        void givenAMenteesIsSubscribedToAMentorThenTheListIsNotEmpty()
        {
            Mentor mentor = Employee.BuildMentor();
            Mentee mentee = Employee.BuildMentee();
            mentor.Subscribe(mentee);
            Assert.NotEmpty(mentor.Mentees);
        }

        [Fact]
        void givenASubscriberUnSubscribeThenItDisappearFromtheList()
        {
            Mentor mentor = Employee.BuildMentor();
            Mentee mentee = Employee.BuildMentee();
            mentor.Subscribe(mentee);
            mentor.UnSubscribe(mentee);
            Assert.Empty(mentor.Mentees);

        }

        [Fact]
        void givenIHaveMenteesThenICanNotifyThem()
        {
            Mock<Subscriber> sub1 = new Mock<Subscriber>();
            Mentor mentor = Employee.BuildMentor();
            mentor.Subscribe(sub1.Object);
            mentor.NotifySubscribers();
            sub1.Setup(mock => mock.Update());
            sub1.Verify(subscriber => subscriber.Update(), Times.Once());

        }
    }
}
