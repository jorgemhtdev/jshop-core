namespace JshopCore.Domain
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public class Order
    {
        public long OrderId { get; set; }

        public string CodeOrder { get; set; }

        public DateTime Date { get; set; }

        public long CustomerId { get; set; }

        [JsonIgnore]
        public virtual Customer Customer { get; set; }

        [JsonIgnore]
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
