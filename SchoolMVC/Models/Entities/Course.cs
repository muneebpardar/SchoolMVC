using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolMVC.Models.Entities
{
    public class Course
    {
        [Column("course_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }

        [Column("title")]
        public string Title { get; set; }
    }
}
