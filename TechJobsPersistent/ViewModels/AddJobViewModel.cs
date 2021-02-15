using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {

        public string Name { get; set; }

        public int EmployerId { get; set; }

        public List<Employer> SelectItemList = new List<Employer>();

        public List<Skill> Skills = new List<Skill>();

        public AddJobViewModel()
        {
        }

        public AddJobViewModel(string name, int employerId, List<Employer> employers, List<Skill> skills)
        {
            Name = name;
            EmployerId = employerId;
            SelectItemList = employers;
            Skills = skills;
        }
    }
}
