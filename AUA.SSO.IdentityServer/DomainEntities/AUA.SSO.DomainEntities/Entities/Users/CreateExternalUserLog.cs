using AUA.SSO.DomainEntities.BaseRepo;

namespace AUA.SSO.DomainEntities.Entities.Users
{
    public class CreateExternalUserLog : BaseEntity<int>
    {
        public bool IsAlive { get; set; }
        public string Mobile { get; set; }
        public string Zipcode { get; set; }
        public string ClientId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string ReturnUrl { get; set; }
        public string ClientName { get; set; }
        public string FatherName { get; set; }
        public string ZipcodeDesc { get; set; }
        public string NationalCode { get; set; }
        public string SecurityCode { get; set; }
        public string ShenasnameNo { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Shenasnameseri { get; set; }
        public string ShenasnameSerial { get; set; }
        public DateTime SecurityCodeExpiration { get; set; }
    }
}