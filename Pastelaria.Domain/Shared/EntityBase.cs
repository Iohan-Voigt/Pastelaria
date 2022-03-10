﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.Domain.Shared
{
    public abstract class EntityBase
    {
        public Guid Id { get => Id; set => Id = value; }

        public abstract string Validate();
        public abstract override string ToString();
    }
}
