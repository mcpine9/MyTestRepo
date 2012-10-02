using System.ComponentModel.DataAnnotations;

namespace VIPRPrototype.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }

        [MaxLength(2)]
        public string State { get; set; }
        public string Zip { get; set; }
    }
}