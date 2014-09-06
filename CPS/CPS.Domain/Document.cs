namespace CPS.Domain
{
    public class Document : Entity
    {
        public virtual string Description { get; set; }
        public virtual string FileName { get; set; }
        public virtual  string FileType { get; set; } 
        public virtual Action Action { get; set; }
    }
}
