namespace CondoManager.Api.Data.Models
{
    public class Company
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public User? Owner { get; set; } = null!;
        public required string Name { get; set; }
        public string? BussinessName { get; set; } // Nome Fantasia - Fantasy Name
        public string? Description { get; set; }
        public int AddressId {  get; set; }
        public virtual Address? Address { get; set; }
        public virtual ShopContact? ShopContact { get; set; }
    }

    public class ShopBussiness
    {
        public int Id { get; set; }
        public string? FederalNumberID { get; set; }
        public string? ZoneNumberID { get; set; }
        public string? MunicipalNumberID { get; set; }

    }

    public class ShopContact
    {
        public int Id { get; set; }
        public string? Site { get; set; }
        public required string Email { get; set; }
        public required string Phone1 { get; set; }
        public string? Phone2 { get; set; }
    }
}
