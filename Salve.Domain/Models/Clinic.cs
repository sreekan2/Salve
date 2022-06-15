using CsvHelper.Configuration.Attributes;
namespace Salve.Domain.Models
{
    public class Clinic
    {
        [Name("id")]
        public int Id { get; set; }

        [Name("name")]
        public string? Name { get; set; }
    }
}