using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution.Domain.Model
{
    public abstract class EntityBase
    {
        public Guid Id { get; protected set; }

        public EntityBase() 
        {
            Id = Guid.NewGuid();
        }
    }
}
