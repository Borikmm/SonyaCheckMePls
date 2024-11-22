using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExam.Models
{
    public class Sales
    {
        [Key]
        public int id { get; set; }
        public int amount { get; set; }
        public string sale_date { get; set; }

        public Product product { get; set; }

        public int partner_id { get; set; }

    }
}
