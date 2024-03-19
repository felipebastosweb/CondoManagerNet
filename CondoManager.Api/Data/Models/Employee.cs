

namespace CondoManager.Api.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User {get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public bool KeepConnected { get; set; }
        public DateTime LastAccess { get; set; }
    }

    public class CondominiumSupervisor
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee {get; set; }
        public int CondominiumId { get; set; }
        public Condominium Condominium {get; set; }
        public DateTime CreationDate { get; set; }
    }
    
    // TODO: adicionar agenda de visitação
}