using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Market
    {
        public int Id { get; set; }
        public string MarketName { get; set; }
        public string MarketType { get; set; }
        public string CreatedContactId { get; set; }
        [Required]
        public Contact CreatedContact { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedContactId { get; set; }
        public Contact UpdatedContact { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

    public class Contact 
    {
        public int Id { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string Gender { get; set; }
    }
}
