using System.ComponentModel.DataAnnotations;

namespace BasicASPTutorial.Modals
{
    public class Student
    {
        [Key]
        public int Student_Id { get; set; }
        [Required]
        public string? Student_Name { get; set; }
        [Range(0,100)]
        public int Student_Score { get; set; }
        [Required]
        public DateTime Student_Cr_at { get; set; }
    }
}
