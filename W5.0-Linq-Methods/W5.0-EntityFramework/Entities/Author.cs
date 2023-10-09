﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5._0_EntityFramework.Entities
{
    public class Author
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Book> Book { get; set; }
    }
}
