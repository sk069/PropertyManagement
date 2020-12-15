using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyManagement.Models
{
    public class Property_Oction
    { 
    //The class contains Oction details for property like, Oction ID and Bid price. Also, it contains foriegn key of Property Id,Customer Id, and Dealer ID.
    // This class is linked with Dealer details class, customer dtail class and property detail class.

    public int Id { get; set; }

    [Required]
    public Decimal Bid_Price { get; set; }

    public int Property_DetailId { get; set; }
    public Property_Detail Property_Detail { get; set; }

    public int Customer_DetailId { get; set; }

    public Customer_Detail Customer_Detail { get; set; }

    public int Dealer_DetailId { get; set; }

    public Dealer_Detail Dealer_Detail { get; set; }

}
}
