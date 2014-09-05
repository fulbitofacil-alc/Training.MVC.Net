namespace CPS.Domain
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
            if (obj.GetType() != typeof(Entity)) return false;
            return Equals(obj as Entity);
        }

        public override int GetHashCode()
        {
            return Id*26574;
        }
    }
}
