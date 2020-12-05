using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DevTeam
    {
        public string ManagerName { get; set; }
        public string DevelporName { get; set; }

        public DevTeam() { }

        public DevTeam (string managerName, string develporName)
        {
            ManagerName = managerName;
            DevelporName = develporName;  //Question how do i display a list of name from directory (enum PersonalDirectory) to allow mulity names before accepting
        }
    }
}
