namespace UniversitarySystem.UsesCases.POCOEntities
{
    public class CollegeCareerEntity
    {
        public int IdCollegeCareer { get; set; }
        public string CollegeCareer { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }


        public int TypeCareersId { get; set; }
        public TypeCareersEntity TypeCareers { get; set; }

        //Propiedad para establecer relación de muchos a muchos.
        public ICollection<Student_CollegeCareerEntity> StudentCollegeCareers { get; set; } = new List<Student_CollegeCareerEntity>();

    }
}
