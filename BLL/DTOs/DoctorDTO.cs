using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class DoctorDTO
    {

        public int Id { get; set; }
        [Required]
       



        public string Uname { get; set; }
        [Required]
        
        public string Name { get; set; }
        [Required]
   
        public string Email { get; set; }
        [Required]
        
        public string Password { get; set; }
        [Required]
      
        public string Address { get; set; }
        [Required]
      
        public string Phonenumber { get; set; }



    }

    internal class RequiredAttribute : Attribute
    {
    }
}
