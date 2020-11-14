using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public enum ClassNameEnum
    {
        [Display(Name ="未分配")]
        None,
        [Display(Name = "一年级")]

        FirstGread,
        [Display(Name = "二年级")]

        SecondGread
    }
}
