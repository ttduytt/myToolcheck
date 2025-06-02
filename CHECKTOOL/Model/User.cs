using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CHECKTOOL.Model
{
    public class User
    {
        public required string UserName { get; set; }
        public required string PassWord { get; set; }
        public required string Role { get; set; }
        public string? FullName { get; set; }
    }

    

}
