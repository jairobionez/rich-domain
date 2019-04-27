using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests.Handlers
{
    [TestClass]
    class SubscriptionHandlerTests
    {
        [TestMethod]
        void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();

            command.FirsName = "Jairo";
            command.LastName = "Bionez";
            command.Document = "9999999999";
            command.Email = "jairo@teste.com";
            command.BarCode = "123456789";
            command.BoletoNumber = "123123";
            command.PayerNumber = "123132132";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddDays(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.Payer = "TOBOGUIM";
            command.PayerDocument = "2132132132";
            command.PayerDocumentType = EDocumentType.CPF;
            command.Street = "sadad";
            command.Number = "asdsad";
            command.Neighborhood = "disney";
            command.City = "disney";
            command.State = "disney";
            command.Country = "disney";
            command.ZipCode = "123123";
            command.PayerEmail = "teste@teste.com";

            handler.Handle(command);
            Assert.AreEqual(false, handler.Valid);
        }
    }
}