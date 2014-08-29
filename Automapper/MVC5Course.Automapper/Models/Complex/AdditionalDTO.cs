namespace MVC5Course.Automapper.Models.Complex
{
    public class AdditionalDTO :ResourceDTO
    {
        public AdditionalDTO()
        {
            _bindingType = this.GetType().Name;
        }    
    }
}