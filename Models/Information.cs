using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormApplication.Models
{
    public class Information
    {
        public string name { set; get; }
        public string id { set; get; } 
        public string gender { set; get; }
        public string profession { set; get; }
        public string[] hobbies { set; get; }

        public Information() { }
        public Information(string name, string id, string gender, string profession,
            string[] hobbies)
        {
            this.name = name;
            this.id = id;
            this.gender = gender;
            this.profession = profession;
            this.hobbies = hobbies;
        }
    }
}