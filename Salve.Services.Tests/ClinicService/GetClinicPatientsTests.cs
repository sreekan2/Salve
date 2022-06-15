using Moq;
using NUnit.Framework;
using Salve.Domain.Models;

namespace Salve.Services.Tests.ClinicService
{
    public class GetClinicPatientsTests : PatientServiceTestBase
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
            MockPatientRepository.Setup(pr => pr.GetPatients()).Returns(new List<Patient>());

            //Act
            var patients = TestPatientService.GetClinicPatients(It.IsAny<int>());

            // Assert
            MockPatientRepository.Verify(pr => pr.GetPatients(), Times.Once);
        }

        [TestCase(1)]
        [TestCase(1)]
        public void Should_return_patients_from_the_provided_clinic(int clinicId)
        {
            // Arrange
            MockPatientRepository.Setup(pr => pr.GetPatients()).Returns(Patients);

            //Act
            var patients = TestPatientService.GetClinicPatients(clinicId);

            // Assert
            Assert.That(patients.Count(x=>x.ClinicId == clinicId), Is.EqualTo(Patients.Count(x => x.ClinicId == clinicId)));
        }
    }
}
