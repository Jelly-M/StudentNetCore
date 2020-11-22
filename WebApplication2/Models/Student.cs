using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "名字必填"), Display(Name = "名字")]
        public string Name { get; set; }

        [Display(Name = "邮箱")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "邮箱格式不正确"), Required(ErrorMessage = "邮箱必填")]
        public string Email { get; set; }

        [Display(Name = "年级")]
        [Required]
        public ClassNameEnum? Gread { get; set; }

        [Display(Name="头像")]
        public string PhotePath { get; set; }
    }
}