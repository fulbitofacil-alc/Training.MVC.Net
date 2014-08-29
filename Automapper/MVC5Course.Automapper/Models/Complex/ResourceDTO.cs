namespace MVC5Course.Automapper.Models.Complex
{
    public abstract class ResourceDTO : BaseDTO
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsEnabled { get; set; }
    }
}