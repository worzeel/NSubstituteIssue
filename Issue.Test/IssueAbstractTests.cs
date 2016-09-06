using Issue;
using NUnit.Framework;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Issue.Test
{
    [TestFixture]
    public class IssueAbstractTests
    {
        private IIssueInterface issueInterface;

        [SetUp]
        public void Setup()
        {
            this.issueInterface = Substitute.For<IIssueInterface>();
        }

        private IssueAbstract SUT()
        {
            return Substitute.For<IssueAbstract>(issueInterface);
        }

        [Test]
        public void TestSomeMethod()
        {
            var sut = SUT();

            sut.MyTestMethod();

            this.issueInterface.Received().SomeMethod();
        }

        [Test]
        public void TestSomeMethodWithArgAny()
        {
            var sut = SUT();

            Arg.Any<string>();

            sut.MyTestMethod();

            this.issueInterface.Received().SomeMethod();
        }

        [Test]
        public void TestSomeMethodWithParam()
        {
            var sut = SUT();

            sut.MyTestMethod();

            this.issueInterface.Received().SomeMethodWithParam("test");
        }

        [Test]
        public void TestSomeMethodWithParamWithArgAny()
        {
            var sut = SUT();

            Arg.Any<string>();

            sut.MyTestMethod();

            // this fails for some reason with "No Received"... only difference is the call to Arg.Any...
            this.issueInterface.Received().SomeMethodWithParam("test");
        }
    }
}
