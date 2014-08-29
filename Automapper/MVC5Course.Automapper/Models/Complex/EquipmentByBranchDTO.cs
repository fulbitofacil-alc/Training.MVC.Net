namespace MVC5Course.Automapper.Models.Complex
{
    public class EquipmentByBranchDTO : ResourceDetailDTO
    {
        public EquipmentDTO Equipment { get; set; }
        public int Quantity { get; set; }
    }
}
