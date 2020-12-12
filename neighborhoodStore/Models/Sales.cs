using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace neighborhoodStore.Models
{
    public enum ClientType
    {
        A, B, C, D
    }

    public class Sales
    {
        public int SalesID { get; set; }
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public ClientType? ClientType { get; set; }

        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}