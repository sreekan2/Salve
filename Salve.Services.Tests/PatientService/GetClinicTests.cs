using Moq;
using NUnit.Framework;
using Salve.Domain.Models;

namespace Salve.Services.Tests.ClinicService
{
    public class GetClinicTests : ClinicServiceTestBase
    {
        [SetUp]
        public void SetupBase()
        {
            SetUp();
            InstantiateUnderTest();
        }

        [Test]
        public void Should_call_Client_repository_once()
        {
            // Arrange
            MockClinicRepository.Setup(cr => cr.GetClinics()).Returns(new List<Clinic>());

            //Act
            var clinics = TestClientService.GetClinics();

            // Assert
            MockClinicRepository.Verify(cr => cr.GetClinics(), Times.Once);
        }

        [Test]
        public void Should_return_all_clincs_provided_by_repository()
        {
            // Arrange
            MockClinicRepository.Setup(cr => cr.GetClinics()).Returns(Clinics);

            //Act
            var clinics = TestClientService.GetClinics();

            // Assert
            Assert.That(clinics.Count(), Is.EqualTo(Clinics.Count()));
        }
    }
}
