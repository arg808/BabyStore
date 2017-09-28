using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BabyStore.Models
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product
    {
    }

    public class ProductMetaData
    {
        [Display(Name = "Product Name")]
        public string Name;
    }
}