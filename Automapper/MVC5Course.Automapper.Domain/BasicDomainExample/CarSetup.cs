using System;

namespace MVC5Course.Automapper.Domain.BasicDomainExample
{
    public class CarSetup
    {
        public string VIN { get; set; }
        public string Maker { get; set; }
        public Guid ExportCode { get; set; }
        public EngineConfiguration Configuration { get; set; }
        public int DefectRate { get; set; }
    }
}