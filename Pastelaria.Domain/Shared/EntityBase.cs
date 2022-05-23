using System;

namespace Pastelaria.Domain.Shared
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }

        public abstract string Validate();

        public abstract override string ToString();
    }
}
