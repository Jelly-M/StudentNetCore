using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.ViewModels
{
    public class StudentViewModel
    {
        public string Title { get; set; }
        public  Student student { get; set; }
    }
}
