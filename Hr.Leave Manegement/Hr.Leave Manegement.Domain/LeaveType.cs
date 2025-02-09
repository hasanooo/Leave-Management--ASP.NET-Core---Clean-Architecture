using Hr.Leave_Manegement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr.Leave_Manegement.Domain
{
    public class LeaveType: BaseDomainEntity
    {
       
        public string Name { get; set; }
        public int DefaultDays { get; set; }

       
    }
}
