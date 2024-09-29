using System.ComponentModel.DataAnnotations;

namespace UniversitarySystem.UsesCases.POCOEntities
{
    public class BloodTypeEntity
    {
        public BloodTypeEntity(int id, string bloodType)
        {
            Id = id;
            BloodType = bloodType;
        }

        public int Id { get; set; }

        [StringLength(maximumLength: 6)] //Anotación para determinar la cantidad de caracteres
        public string BloodType { get; set; }
    }
}
