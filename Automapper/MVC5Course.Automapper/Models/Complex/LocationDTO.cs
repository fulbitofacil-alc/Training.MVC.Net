namespace MVC5Course.Automapper.Models.Complex
{
    public class LocationDTO
    {
        public string City { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}", Address, Province, District, City);
        }
    }
}