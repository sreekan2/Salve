using Salve.Domain.Models;

namespace Salve.DataAccess.Interfaces
{
    public interface IPatientRepository
    {
        /// <summary>
        /// Gets the list of patients.
        /// </summary>
        /// <returns>list of <see cref="Patient"/>.</returns>
        IEnumerable<Patient> GetPatients();
    }
}
