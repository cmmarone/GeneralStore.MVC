using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Transaction
    {
        [Key]
        [Display(Name = "Transaction ID")]
        public int TransactionId { get; set; }

        [Required]
        [Display(Name = "Customer ID")]
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }

        [Required]
        [Display(Name = "Product ID")]
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Quantity Purchased")]
        public int QuantityPurchased { get; set; }

        [Display(Name = "Transaction Date and Time")]
        public DateTime Time { get; set; }


        //navigation properties
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}