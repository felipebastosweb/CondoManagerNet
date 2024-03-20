namespace CondoManager.Api.Data.Models
{
    public class Country
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Code { get; set; }
    }
    public class Zone
    {
        public int Id { get; set; }
        public int ZoneId { get; set; }
        public Country? Country { get; set; }
        public required string Name { get; set; }
        public required string Code { get; set; }
    }

    public class Address
    {
        public int Id { get; set; }
        public int ZoneId { get; set; }
        public Zone? Zone {  get; set; }
        public required string Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? ZipCode {  get; set; }
    }
}
