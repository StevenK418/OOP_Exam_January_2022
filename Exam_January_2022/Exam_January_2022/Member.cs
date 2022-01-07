using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_January_2022
{
    class Member
    {

        public enum PaymentSchedule
        {
            annual,
            biannual,
            monthly
        }

        public string name { get; set; }
        public DateTime JoinDate { get; set; }
        public decimal Fee { get; set; }
        public PaymentSchedule? paymentSchedule { get; set; }

        public DateTime RenewalDate 
        { 
            get
            {
                //Add a year to join date 
                return JoinDate.AddYears(1);
            } 
        }

        public double DateToRenewal 
        { 
            get 
            {
                DateTime startDate = JoinDate;
                DateTime endDate =  RenewalDate;
                return (endDate - startDate).TotalDays;
            } 
        }


        /// <summary>
        /// Paramterised constructor. Initializes properties values on instatiation
        /// </summary>
        /// <param name="name"></param>
        /// <param name="joinDate"></param>
        /// <param name="fee"></param>
        /// <param name="PaymentSchedule"></param>
        public Member(string name, DateTime joinDate, decimal fee, PaymentSchedule PaymentSchedule)
        {
            this.name = name;
            JoinDate = joinDate;
            Fee = fee;
            paymentSchedule = PaymentSchedule;
        }

        /// <summary>
        /// Overrides the ToString method of the parent Object class. 
        /// </summary>
        /// <returns>Returns a formatted string of info pertaining to the given instance.</returns>
        public override string ToString()
        {
            return $"{name}";
        }
    }
}
