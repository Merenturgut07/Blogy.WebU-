﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.EntityLayer.Concrete
{
	public class AppRole:IdentityRole<int>
	{
        public string Description { get; set; }
    }
}
