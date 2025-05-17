namespace CabManagementSystem
{
    public class Car
    {
        public int CarId { get; set; }
        public string Model { get; set; }
        public string PlateNumber { get; set; }
        public bool Availability { get; set; }

        public Car(int carId, string model, string plateNumber, bool availability)
        {
            CarId = carId;
            Model = model;
            PlateNumber = plateNumber;
            Availability = availability;
        }

        public string GetDetails()
        {
            return $"Car ID: {CarId}, Model: {Model}, Plate Number: {PlateNumber}, Available: {Availability}";
        }

        public void UpdateAvailability(bool availability)
        {
            Availability = availability;
        }
    }
}
