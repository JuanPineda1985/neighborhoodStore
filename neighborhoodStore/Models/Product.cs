using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace neighborhoodStore.Models
{
    public class Product
    {
       [DatabaseGenerated(DatabaseGeneratedOption.None)]
       public int ProductID { get; set; }
       public string ProductName { get; set; } 
       public int Price { get; set; }

       public virtual ICollection<Sales> Sales { get; set; }
    }
}