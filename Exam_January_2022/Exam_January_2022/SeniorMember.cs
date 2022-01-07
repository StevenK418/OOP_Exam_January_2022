using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_January_2022
{
    class SeniorMember:Member
    {
        public SeniorMember(string name, DateTime joinDate, decimal fee, PaymentSchedule PaymentSchedule) : base(name, joinDate, fee, PaymentSchedule)
        {

        }
    }
}
