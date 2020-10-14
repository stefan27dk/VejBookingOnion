using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Common
{
    public class BasePerson : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }      
    }
}
