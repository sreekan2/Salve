using Salve.DataAccess.Interfaces;
using Salve.Domain.Models;
using Salve.Services.Interfaces;

namespace Salve.Services
{
    public class ClinicService : IClinicService
    {
        private readonly IClinicRepository _clinicRepository;

        public ClinicService(IClinicRepository clinicRepository)
        {
            _clinicRepository = clinicRepository;
        }

        /// <inheritdoc />
        public IEnumerable<Clinic> GetClinics()
        {
            return _clinicRepository.GetClinics();
        }
    }
}
