using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace strongalyTypedHtmlHelperDemo.Models
{
    public class SignUp
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public int UserPassword { get; set; }
        public int UserGender { get; set;}
        public int UserEmail { get; set;}
        public int UserComment { get; set;}
       
    }
    
}