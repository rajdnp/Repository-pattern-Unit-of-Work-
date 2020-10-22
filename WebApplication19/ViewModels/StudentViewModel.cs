using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication19.ViewModels
{
    public class StudentViewModel
    {
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public decimal? TotalFee { get; set; }
        public decimal? Paid { get; set; }
        public decimal? Due { get; set; }
        public long? ClassId { get; set; }
        public string Address { get; set; }
        public long AaadharNumber { get; set; }
    }
}
