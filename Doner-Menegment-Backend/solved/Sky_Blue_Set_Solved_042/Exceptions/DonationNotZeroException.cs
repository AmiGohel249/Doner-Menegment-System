using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sky_Blue_Set_Solved_042.Exceptions
{
    public class DonationNotZeroException:Exception
    {
        public DonationNotZeroException():base("Donation Cannot be less than Zero") { }
    }
}