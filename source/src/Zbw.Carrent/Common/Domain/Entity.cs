namespace Zbw.Carrent.Common.Domain
{
    public abstract class Entity
    {
        public Entity()
        {
        }
        public Entity(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
    }
}
