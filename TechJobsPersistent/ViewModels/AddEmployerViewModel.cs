﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {

        public string Name { get; set; }

        public string Location { get; set; }

        public AddEmployerViewModel()
        {

        }

        public AddEmployerViewModel(string name, string location)
        {
            Name = name;
            Location = location;
        }
    }
}
