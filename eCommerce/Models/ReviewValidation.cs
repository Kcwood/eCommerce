using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    [MetadataType(typeof(ReviewValidation))]
    public partial class Review
    {

    }
    public class ReviewValidation
    {
        [Required, MaxLength(100)]
        public string Username { get; set; }
        [Required, MaxLength(250)]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required, Display(Name="Date")]
        public System.DateTime DateCreated { get; set; }
        [Required]
        public int ProductID { get; set; }
    }
}