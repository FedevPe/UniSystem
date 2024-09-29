namespace UniversitarySystem.UsesCases.ValueObjects
{
    public class DetailTypeVO
    {
        public DetailTypeVO(int id, int type)
        {
            Id = id;
            Type = type;
        }

        public int Id { get; set; }
        public int Type { get; set; }
    }
}
