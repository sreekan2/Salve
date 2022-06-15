using CsvHelper.Configuration.Attributes;

namespace Salve.Domain.Models
{
    public class Patient
    {
        [Name("id")]
        public int Id { get; set; }

        [Name("clinic_id")]
        public int ClinicId { get; set; }

        [Name("first_name")]
        public string? FirstName { get; set; }

        [Name("last_name")]
        public string? LastName { get; set; }

        [Name("date_of_birth")]
        public string? DateOfBirth { get; set; }
    }
}
