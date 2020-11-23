using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.ViewModels
{
    public class StudentEditViewModel:StudentCreateViewModel
    {
        public int Id { get; set; } //编辑需要ID
        public string ExistsPath { get; set; }//图片路径
    }
}
