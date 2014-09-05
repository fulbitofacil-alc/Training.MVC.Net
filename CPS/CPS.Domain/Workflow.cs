namespace CPS.Domain
{
    public class Workflow : Entity
    {
        public virtual string Name { get; set; }
        public virtual int Priority { get; set; }
        public virtual int Duration { get; set; }
    }
}
