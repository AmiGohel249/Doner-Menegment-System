using Sky_Blue_Set_Solved_042.Exceptions;
using Sky_Blue_Set_Solved_042.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Sky_Blue_Set_Solved_042.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DonorServiceController : ApiController
    {
        DonorDBEntities context = new DonorDBEntities();
        [HttpGet]
        public List<TBLDonor> ShowDonor()
        {
            return context.TBLDonors.ToList();
        }
        public object PostAddBook(TBLDonor donor)
        {
            try
            {
                if (donor.donation_amt <= 0)
                {
                    throw new DonationNotZeroException();

                }
                var data1 = context.TBLDonors.ToList();
                for (int i = 0; i < data1.Count; i++)
                {
                    if (data1[i].aadhar_number.Equals(donor.aadhar_number))
                    {
                        throw new AadharAlreadyExistsException();
                    }
                }
                context.TBLDonors.Add(donor);
                context.SaveChanges();
                return new { output = true, message = "" };
            }
            catch (DonationNotZeroException ex)
            {
                return new { output = false, message = ex.Message };

            }
            catch (AadharAlreadyExistsException ex)
            {
                return new { output = false, message = ex.Message };

            }
        }
    }
}