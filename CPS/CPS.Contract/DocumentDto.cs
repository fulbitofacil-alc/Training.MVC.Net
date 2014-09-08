namespace CPS.Contract
{
    public class DocumentDto
    {
        public string Description { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public ActionDto Action { get; set; } 
    }
}