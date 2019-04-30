namespace JshopCore.Domain
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Product
    {
        public long ProductId { get; set; }

        public string Name { get; set; }

        public double Amount { get; set; }

        public long CategoryId { get; set; }

        [JsonIgnore]
        public virtual Category Category { get; set; }

        [JsonIgnore]
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
