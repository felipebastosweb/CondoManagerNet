
namespace CondoManager.Api.Data.Models
{
    public class Condominium
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public User Owner {get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public DateTime CreationDate { get; set; }
    }

    // TODO: adicionar unidades e áreas comuns
    // TODO: adicionar reserva de áreas comuns
}