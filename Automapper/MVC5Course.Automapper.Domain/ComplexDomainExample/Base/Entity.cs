namespace MVC5Course.Automapper.Domain.ComplexDomainExample.Base
{
    public abstract class Entity
    {
        public virtual int Id { get; set; }

        public virtual bool Equals(Entity other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.Id == Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == typeof(Entity) && Equals(obj as Entity);
        }

        public override int GetHashCode()
        {
            return Id * 31415;
        }

    }
}