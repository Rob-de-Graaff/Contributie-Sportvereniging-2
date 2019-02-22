using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contributie
{
    class Member
    {
        private string name;
        private DateTime dateOfBirth;
        private DateTime startdate;
        private double contribution;
        private double discount;//
        private double memberDiscount;//
        private int memberLimit;

        public Member(string name, DateTime dateOfBirth, DateTime startdate, double contribution, double discount, double memberDiscount, int memberLimit)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.startdate = startdate;
            this.contribution = contribution;
            this.discount = discount;
            this.memberDiscount = memberDiscount;
            this.memberLimit = memberLimit;
        }

        public override string ToString()
        {
            return $"Name:{name}, Date of birth:{dateOfBirth}, Started:{startdate}, Contribution:{contribution}";
        }

        public string Name
        {
            get { return name; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
        }

        public DateTime StartDate
        {
            get { return startdate; }
        }

        public double Contribution
        {
            get { return contribution; }
        }

        public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public double MemberDiscount
        {
            get { return memberDiscount; }
            set { memberDiscount = value; }
        }

        public int MemberLimit
        {
            get { return memberLimit; }
        }
    }
}
