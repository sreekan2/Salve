using Salve.Domain.Models;

namespace Salve.Services.Interfaces
{
    public interface IClinicService
    {
        /// <summary>
        /// Gets the list of clinics.
        /// </summary>
        /// <returns>list of <see cref="Clinic"/></returns>
        IEnumerable<Clinic> GetClinics();
    }
}
