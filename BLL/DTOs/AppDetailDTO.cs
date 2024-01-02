using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AppDetailDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public double DoctorFees { get; set; }
        [Required]
        public int AppId { get; set; }
        [Required]
        public string DcMail { get; set; }
    }
}
