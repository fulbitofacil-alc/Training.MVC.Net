namespace MVC5Course.Automapper.Models.Complex
{
    public abstract class BaseDTO
    {
        public int Id { get; set; }
        protected string _bindingType;
        public string BindingType
        {
            get { return _bindingType; }
        }
    }
}