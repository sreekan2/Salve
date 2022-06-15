using Microsoft.AspNetCore.Mvc;
using Salve.Domain.Models;
using Salve.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Salve.API.Controllers
{
    [ApiController]
    [Route("api/patient")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        /// <summary>
        /// Gets the list of Patients from the requested clinic.
        /// </summary>
        /// <param name="clinicId">the clinic Id to get the Patients.</param>
        /// <returns>List of <see cref="Patient"/>.</returns>
        [HttpGet]
        [Route("Get/{clinicId}")]
        public IEnumerable<Patient> GetClinicPatients([Required] int clinicId)
        {
            return _patientService.GetClinicPatients(clinicId);
        }

    }
}
