using System;
using System.ComponentModel.DataAnnotations;

namespace PriceQuote.Models
{
    public class PriceQuoteModel
    {
        [Required(ErrorMessage = "Please enter a total greater than zero")]
        public decimal? Subtotal { get; set; }

        [Required(ErrorMessage = "Please enter a number between 0 and 100")]
        [Range(0, 100)]
        public int? DiscountRate { get; set; }

        public decimal Amount()
        {
            decimal amount = Subtotal.Value * DiscountRate.Value / 100;

            return amount;
        }

        public decimal Total()
        {
            
            decimal total = Subtotal.Value - Amount();

            return total;
            
        }


    }
}
