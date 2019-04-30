using System;
using System.Collections.Generic;
using System.Text;

namespace JshopCore.Domain
{
    public class OrderProduct
    {
        public long OrderProductId { get; set; }

        public long OrderId { get; set; }
        public long ProductId { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
