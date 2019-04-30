namespace JshopCore.Domain
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Category
    {
        public long CategoryId { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Product> Products { get; set; }
    }
}
