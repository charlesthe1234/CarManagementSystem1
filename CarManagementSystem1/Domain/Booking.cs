using System.Data;

namespace CarManagementSystem1.Domain
{
    public class Booking: BaseDomainModel
    {
        public DateTime DateOur { get; set; }
        public DateTime DateIn {  get; set; }
        public int VehicleId {  get; set; }
        public int CustomerId { get; set; }
    }
}
