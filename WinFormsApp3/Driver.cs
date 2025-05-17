namespace CabManagementSystem
{
    public class Driver
    {
        public int DriverId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public bool Availability { get; set; }

        public Driver(int driverId, string name, string contactNumber, bool availability)
        {
            DriverId = driverId;
            Name = name;
            ContactNumber = contactNumber;
            Availability = availability;
        }

        public string GetDetails()
        {
            return $"Driver ID: {DriverId}, Name: {Name}, Contact: {ContactNumber}, Available: {Availability}";
        }

        public void UpdateAvailability(bool availability)
        {
            Availability = availability;
        }
    }
}
