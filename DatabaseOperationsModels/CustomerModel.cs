namespace DatabaseOperationsModels
{
    public class CustomerModel
    {
        public string CustomerIdentification { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }

        public CustomerModel
            (string customerIdentification, string companyName, string contactName, string contactTitle, string address, string city, string region, string postalCode, string country, string phoneNumber, string faxNumber)
        {
            CustomerIdentification = customerIdentification;
            CompanyName = companyName;
            ContactName = contactName;
            ContactTitle = contactTitle;
            Address = address;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;
            PhoneNumber = phoneNumber;
            FaxNumber = faxNumber;
        }
    }
}
