namespace MVC5Course.Automapper.Models.Complex
{
    public class BranchDTO : BaseDTO
    {
        public string Name { get; set; }
        public LocationDTO Address { get; set; }
    }
}
