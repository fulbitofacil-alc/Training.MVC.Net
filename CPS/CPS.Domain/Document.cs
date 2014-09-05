namespace CPS.Domain
{
    public class Document : Entity
    {
        public string Description { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; } 
        public virtual Action Action { get; set; }
    }
}
