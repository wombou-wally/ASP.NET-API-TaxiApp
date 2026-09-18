namespace TaxiApp.Models
{
    public class Ride
    {
        public int RideId {  get; set; }
        public string UserId {  get; set; }
        public string PickupLocation {  get; set; }
        public string DropoffLocation {  get; set; }
        public string Status {  get; set; }
        public DateTime CreatedAt {  get; set; }

    }
}
