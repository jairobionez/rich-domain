using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Repositories;

namespace PaymentContext.Tests.Mocks
{
    public class FakeStudentRepository : IStudentRepository
    {
        public void CreateSubscription(Student student)
        {
            throw new System.NotImplementedException();
        }

        public bool DocumentExists(string document)
        {
            if(document == "9999999999")
                return true;
            return false;            
        }

        public bool EmailExists(string email)
        {
            throw new System.NotImplementedException();
        }
    }
}