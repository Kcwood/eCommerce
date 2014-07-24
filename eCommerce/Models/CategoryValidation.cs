using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //add using for data annotations

namespace eCommerce.Models
{
    //add metadata type data annotation
    [MetadataType(typeof(CategoryValidation))]
    public partial class Category //create the public partial classs 
    {

    }

    public class CategoryValidation
    {
        //Get the properties from the .edmx > .tt file
        [Required,MaxLength(100)]
        public string Name { get; set; }
        [Display(Name="Parent Category")]
        public Nullable<int> ParentID { get; set; }
    }
}