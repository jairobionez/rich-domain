using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;

namespace PaymentContext.Tests.Commands
{
    [TestClass]
    public class CreateBoletoSubscriptionCommandTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenNameIsInvalid(){
            var command = new CreateBoletoSubscriptionCommand();
            command.FirsName = "";

            command.Valdiate();

            Assert.AreEqual(false, command.Valid);
        }
    }
}