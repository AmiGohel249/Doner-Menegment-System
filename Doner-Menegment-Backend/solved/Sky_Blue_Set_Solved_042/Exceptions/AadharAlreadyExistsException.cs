using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sky_Blue_Set_Solved_042.Exceptions
{
    public class AadharAlreadyExistsException:Exception
    {
        public AadharAlreadyExistsException():base("Aadhar Number Already Exists") { }
    }
}