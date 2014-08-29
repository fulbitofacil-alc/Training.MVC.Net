namespace MVC5Course.Automapper.Models.Complex
{
    public class OfficeByBranchDTO : ResourceDetailDTO
    {
        public OfficeDTO Office { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
    }
}
