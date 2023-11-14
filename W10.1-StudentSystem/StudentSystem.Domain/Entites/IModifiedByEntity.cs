﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Domain.Entites
{
    public interface IModifiedByEntity
    {
        public string? ModifiedByUserId { get; set; }

        public DateTimeOffset? LastModifiedOn { get; set; }
    }
}
