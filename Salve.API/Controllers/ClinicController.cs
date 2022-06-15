using Microsoft.AspNetCore.Mvc;
using Salve.Domain.Models;
using Salve.Services.Interfaces;

namespace Salve.API.Controllers
{
    [ApiController]
    [Route("api/clinic")]
    public class ClinicController : ControllerBase
    {
        private readonly IClinicService _clinicService;

        public ClinicController(IClinicService clinicService)
        {
            _clinicService = clinicService;
        }

        /// <summary>
        /// Gets the List of Clinics.
        /// </summary>
        /// <returns>List of <see cref="Clinic"/>.</returns>
        [HttpGet]
        [Route("Get")]
        public IEnumerable<Clinic> GetClinics()
        {
            return _clinicService.GetClinics();
        }

    }
}
