using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Issue
{
    public abstract class IssueAbstract
    {
        private IIssueInterface issueInterface;

        public IssueAbstract(IIssueInterface issueInterface)
        {
            this.issueInterface = issueInterface;
        }

        public void MyTestMethod()
        {
            this.issueInterface.SomeMethod();
            this.issueInterface.SomeMethodWithParam("test");
        }

        public void MyTestMethodWithParam(string param)
        {
            this.issueInterface.SomeMethod();
            this.issueInterface.SomeMethodWithParam("test");
        }
    }
}
