namespace WaveAndPlay.Web.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string HouseNumber { get; set; }

        public Address(int id, string country, string city, string postalCode, string street, string streetNumber, string houseNumber)
        {
            Id = id;
            Country = country;
            City = city;
            PostalCode = postalCode;
            Street = street;
            StreetNumber = streetNumber;
            HouseNumber = houseNumber;
        }
    }
}
