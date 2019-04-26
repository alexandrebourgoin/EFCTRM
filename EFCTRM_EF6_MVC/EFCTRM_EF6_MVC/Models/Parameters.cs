using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFCTRM_EF6_MVC.Models
{
    public enum MarketType
    {
        Daily, Monthly
    }

    public class Market
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MarketType Type { get; set; }
        public int CreatedContactId { get; set; }
        public Contact CreatedContact { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int UpdateContactId { get; set; }
        public Contact UpdatedContact { get; set; }
        public DateTime UpdateDateTime { get; set; }
    }

    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }

}