using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSchedule.Data.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException() : this("Entity does not exist.")
        {

        }

        public EntityNotFoundException(string message) : base(message)
        {

        }
    }
}
