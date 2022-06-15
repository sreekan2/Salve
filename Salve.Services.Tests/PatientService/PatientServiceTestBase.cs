using Moq;
using Salve.DataAccess.Interfaces;
using Salve.Domain.Models;

namespace Salve.Services.Tests.ClinicService
{
    public class PatientServiceTestBase
    {
        protected Mock<IPatientRepository> MockPatientRepository;
        protected PatientService TestPatientService;

        public void SetUp()
        {
            MockPatientRepository = new Mock<IPatientRepository>();
        }

        protected void InstantiateUnderTest()
        {
            TestPatientService = new PatientService(MockPatientRepository.Object);

        }

        protected IEnumerable<Patient> Patients => new List<Patient>
        {
            new Patient
            {
                Id = 1,
                FirstName = "Test Patient 1 First Name",
                LastName = "Test Patient 1 Last Name",
                ClinicId = 1,
                DateOfBirth = "01-01-2001",
            },
            new Patient
            {
                Id = 2,
                FirstName = "Test Patient 2 First Name",
                LastName = "Test Patient 2 Last Name",
                ClinicId = 2,
                DateOfBirth = "02-02-2002",
            },
             new Patient
            {
                Id = 3,
                FirstName = "Test Patient 3 First Name",
                LastName = "Test Patient 3 Last Name",
                ClinicId = 2,
                DateOfBirth = "03-03-2003",
            }
        };
    }
}
