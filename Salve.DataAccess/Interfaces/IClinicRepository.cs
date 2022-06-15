using Salve.Domain.Models;

namespace Salve.DataAccess.Interfaces
{
    public interface IClinicRepository
    {
        /// <summary>
        /// Gets the list of clinics.
        /// </summary>
        /// <returns>list of <see cref="Clinic"/></returns>
        IEnumerable<Clinic> GetClinics();
    }
}
