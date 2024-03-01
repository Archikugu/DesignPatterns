using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee NextApprover;
        public void SetNextApprover(Employee SuperVisor)
        {
            this.NextApprover = SuperVisor;
        }
        public abstract void ProcessRequest(CustomerProcessViewModel req);
    }
}
