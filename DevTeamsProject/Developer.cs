using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class Developer
    {
        public string DeveloperName { get; set; }
        public int IdNumber { get; set; }
        public string Manager { get; set; }
        public bool SoftwareLicense { get; set; }


        public Developer() { }

        public Developer(string developerName, int idNumber, string manager, bool softwareLicense)
        {
            DeveloperName = developerName;
            IdNumber = idNumber;
            Manager = manager;
            SoftwareLicense = softwareLicense;
        }
    }
}

