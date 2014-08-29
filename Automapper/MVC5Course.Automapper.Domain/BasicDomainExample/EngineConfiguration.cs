namespace MVC5Course.Automapper.Domain.BasicDomainExample
{
    public class EngineConfiguration
    {
        public string ModelNumber { get; set; }
        public int ModelYear { get; set; }

        public int CylinderCount()
        {
            return 8;
        }
     
    }
}