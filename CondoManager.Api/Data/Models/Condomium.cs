
namespace CondoManager.Api.Data.Models
{
    public class Condominium
    {
        public int Id { get; set; }
        public int ManagerId { get; set; }
        public User? Manager {get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? Email { get; set; }
        public string? Telephone { get; set; }
        public required virtual Address Address { get; set; }
        public DateTime CreationDate { get; set; }
    }

    // TODO: adicionar unidades e áreas comuns
    // TODO: adicionar reserva de áreas comuns
}