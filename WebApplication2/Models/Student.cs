using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "名字必填"), Display(Name = "名字")]
        public string Name { get; set; }

        [Display(Name = "邮箱")]
        [RegularExpression(@"^\\s*([A-Za-z0-9_-]+(\\.\\w+)*@(\\w+\\.)+\\w{2,5})\\s*$", ErrorMessage = "邮箱格式不正确"), Required(ErrorMessage = "邮箱必填")]
        public string Email { get; set; }

        [Display(Name = "年级")]
        [Required]
        public ClassNameEnum? Gread { get; set; }
    }
}