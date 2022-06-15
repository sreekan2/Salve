using Salve.Domain.Models;

namespace Salve.Services.Interfaces
{
    public interface IPatientService
    {
        /// <summary>
        /// Gets the list of patients for the given clinic.
        /// </summary>
        /// <param name="clientId">Clinic for which we need patients.</param>
        /// <returns>List of <see cref="Patient"/>.</returns>
        IEnumerable<Patient> GetClinicPatients(int clientId);
    }
}
