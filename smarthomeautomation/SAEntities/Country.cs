﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class Country : CommonProperty
    {
        [Required, MaxLength(200)]
        public string Name { get; set; }
        [Required, MaxLength(10)]
        public string Code { get; set; }
        public IList<State> States { get; set; }

    }
}
