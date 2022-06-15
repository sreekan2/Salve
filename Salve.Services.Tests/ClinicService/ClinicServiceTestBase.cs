using Moq;
using Salve.DataAccess.Interfaces;
using Salve.Domain.Models;

namespace Salve.Services.Tests.ClinicService
{
    public class ClinicServiceTestBase
    {
        protected Mock<IClinicRepository> MockClinicRepository;
        protected Services.ClinicService TestClientService;

        public void SetUp()
        {
            MockClinicRepository = new Mock<IClinicRepository>();
        }

        protected void InstantiateUnderTest()
        {
            TestClientService = new Services.ClinicService(MockClinicRepository.Object);

        }

        protected static IEnumerable<Clinic> Clinics => new List<Clinic>
        {
            new Clinic
            {
                Id = 1,
                Name = "Test Clinic 1"
            },
            new Clinic
            {
                Id = 2,
                Name = "Test Clinic 2"
            }
        };
    }
}
