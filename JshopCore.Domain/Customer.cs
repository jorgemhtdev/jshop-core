namespace JshopCore.Domain
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Customer
    {
        public long CustomerId { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }

        [JsonIgnore]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
