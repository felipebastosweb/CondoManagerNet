namespace CondoManager.Api.Data.Models
{
    public class Unit
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int CondominiumId { get; set; }
        public virtual Condominium? Condominium { get; set; }
    }
}
