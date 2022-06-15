using Salve.DataAccess.Interfaces;
using Salve.Domain.Models;
using CsvHelper;
using System.Globalization;

namespace Salve.DataAccess
{
    public class ClinicRepository : IClinicRepository
    {
        // I am assuming we read data from the provided csv files.

        /// <inheritdoc/>
        public IEnumerable<Clinic> GetClinics()
        {
            // This can be add it to the app settings and read the path from there
            var fileName = "clinics.csv";
            var clinicsFile = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory())!.FullName, @"Salve.DataAccess\Data\", fileName);
            using (var stream = new StreamReader(@clinicsFile))
            {
                using (var reader = new CsvReader(stream, CultureInfo.InvariantCulture))
                {
                    var clinics = reader.GetRecords<Clinic>().ToList();
                    return clinics;
                }
            }
        }        
    }
}