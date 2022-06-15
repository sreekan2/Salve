using CsvHelper;
using Salve.DataAccess.Interfaces;
using Salve.Domain.Models;
using System.Globalization;

namespace Salve.DataAccess
{
    public class PatientRepository : IPatientRepository
    {
        /// <inheritdoc/>
        public IEnumerable<Patient> GetPatients()
        {
            // This can be add it to the app settings and read the path from there
            DirectoryInfo directory = new DirectoryInfo(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory())!.FullName, @"Salve.DataAccess\Data\"));
            FileInfo[] files = directory.GetFiles("*.csv");
            var patients = new List<Patient>();
            foreach (var file in files)
            {
                if (file.Name.StartsWith("patient"))
                {
                    using (var stream = new StreamReader(file.FullName))
                    {
                        using (var reader = new CsvReader(stream, CultureInfo.InvariantCulture))
                        {
                            var filePatients = reader.GetRecords<Patient>().ToList();
                            patients.AddRange(filePatients);
                        }
                    }
                }                
            }
            return patients;
            
        }
    }
}
