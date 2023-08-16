namespace BlazorApp.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? ClassName { get; set; }
        public string? DivName { get; set; }
        public StudentModel Clone()
        {
            return new StudentModel
            {
                Id = this.Id,
                Name = this.Name,
                ClassName = this.ClassName,
                DivName = this.DivName
            };
        }

    }
}
