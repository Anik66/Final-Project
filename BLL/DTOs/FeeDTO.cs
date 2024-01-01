using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class FeeDTO
    {
        public int Id { get; set; }
        public double Paid { get; set; }
        public DateTime PaymentDate { get; set; }
        public int PId { get; set; }
        public int AID { get; set; }
    }
}
