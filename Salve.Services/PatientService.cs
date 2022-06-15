using Salve.DataAccess.Interfaces;
using Salve.Domain.Models;
using Salve.Services.Interfaces;

namespace Salve.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;
        public PatientService(IPatientRepository patientRepository )
        {
            _patientRepository = patientRepository;
        }


        /// <inheritdoc />
        public IEnumerable<Patient> GetClinicPatients(int clinicId)
        {
            var patients =  _patientRepository.GetPatients();

            return patients.Where(p => p.ClinicId == clinicId);
        }
    }
}
