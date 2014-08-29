namespace MVC5Course.Automapper.Models.Complex
{
    public class ServiceDTO : ResourceDTO
    {
        public ServiceDTO()
        {
            _bindingType = this.GetType().Name;
        }

    }
}
