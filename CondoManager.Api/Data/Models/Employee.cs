

namespace CondoManager.Api.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User? User {get; set; }
        public int CompanyId { get; set; }
        public virtual Company? Company { get; set; }
        public required string Name { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }
        public required string Address { get; set; }
        public bool KeepConnected { get; set; }
        public DateTime LastAccess { get; set; }
    }

    public class CondominiumSupervisor
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int CondominiumId { get; set; }
        public Employee? Employee {get; set; }
        public Condominium? Condominium {get; set; }
        public DateTime CreationDate { get; set; }
    }
    
    // TODO: adicionar agenda de visitação
}