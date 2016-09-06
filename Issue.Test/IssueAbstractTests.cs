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

            sut.MyTestMethod();

            this.issueInterface.Received().SomeMethodWithParam(Arg.Any<string>());
        }

        [Test]
        public void TestMyTestMethodWithParam1()
        {
            var sut = SUT();

            sut.MyTestMethodWithParam(Arg.Any<string>());

            this.issueInterface.Received().SomeMethod();
        }

        [Test]
        public void TestMyTestMethodWithParam2()
        {
            var sut = SUT();

            sut.MyTestMethodWithParam(string.Empty);

            this.issueInterface.Received().SomeMethodWithParam(Arg.Any<string>());
        }

        [Test]
        public void TestMyTestMethodWithParam3()
        {
            var sut = SUT();

            sut.MyTestMethodWithParam(Arg.Any<string>());

            this.issueInterface.Received().SomeMethodWithParam(Arg.Any<string>());
        }
    }
}
