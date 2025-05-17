using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CabManagementSystem
{
    public class Customer                    
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string CurrentLocation { get; set; }
        public string Destination { get; set; }
        private string connectionString;

        public Customer(int customerId, string name, string contactNumber, string currentLocation, string destination, string connectionString)
        {
            CustomerId = customerId;
            Name = name;
            ContactNumber = contactNumber;
            CurrentLocation = currentLocation;
            Destination = destination;
            this.connectionString = connectionString;
        }

        public string GetDetails()
        {
            return $"Customer ID: {CustomerId}, Name: {Name}, Contact: {ContactNumber}, Location: {CurrentLocation}, Destination: {Destination}";
        }

        public List<Car> ShowAvailableCars()
        {
            List<Car> cars = new List<Car>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM cars WHERE availability = 1";
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int carId = Convert.ToInt32(reader["CarId"]);
                    string model = reader["Model"].ToString();
                    string plateNumber = reader["PlateNumber"].ToString();
                    bool availability = Convert.ToBoolean(reader["availability"]);
                    cars.Add(new Car(carId, model, plateNumber, availability));
                }
            }
            return cars;
        }

        public List<Driver> ShowAvailableDrivers()
        {
            List<Driver> drivers = new List<Driver>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM drivers WHERE availability = 1";
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int driverId = Convert.ToInt32(reader["DriverId"]);
                    string name = reader["Name"].ToString();
                    string contactNumber = reader["ContactNumber"].ToString();
                    bool availability = Convert.ToBoolean(reader["availability"]);
                    drivers.Add(new Driver(driverId, name, contactNumber, availability));
                }
            }
            return drivers;
        }
        public List<Car> ViewAvailableCars()
        {
            List<Car> cars = new List<Car>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM cars WHERE availability = 1";
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int carId = Convert.ToInt32(reader["car_id"]);
                    string model = reader["model"].ToString();
                    string plateNumber = reader["plate_number"].ToString();
                    bool availability = Convert.ToBoolean(reader["availability"]);
                    cars.Add(new Car(carId, model, plateNumber, availability));
                }
            }
            return cars;
        }

        public List<Driver> ViewAvailableDrivers()
        {
            List<Driver> drivers = new List<Driver>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM drivers WHERE availability = 1";
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int driverId = Convert.ToInt32(reader["driver_id"]);
                    string name = reader["name"].ToString();
                    string contactNumber = reader["contact_number"].ToString();
                    bool availability = Convert.ToBoolean(reader["availability"]);
                    drivers.Add(new Driver(driverId, name, contactNumber, availability));
                }
            }
            return drivers;
        }

        public void PlaceOrder(int customerId, int carId, int driverId, string currentLocation, string destination)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO orders (CustomerId, CarId, DriverId, OrderDate, CurrentLocation, Destination) VALUES (@CustomerId, @CarId, @DriverId, NOW(), @CurrentLocation, @Destination)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerId", customerId);
                    command.Parameters.AddWithValue("@CarId", carId);
                    command.Parameters.AddWithValue("@DriverId", driverId);
                    command.Parameters.AddWithValue("@CurrentLocation", currentLocation);
                    command.Parameters.AddWithValue("@Destination", destination);

                    connection.Open();
                    command.ExecuteNonQuery();
                    UpdateCarAvailability(carId, false);
                    UpdateDriverAvailability(driverId,false);
                }
            }
        }


        public void UpdateCarAvailability(int carId, bool availability)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "UPDATE cars SET availability = @Availability WHERE CarId = @CarId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Availability", availability);
                command.Parameters.AddWithValue("@CarId", carId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateDriverAvailability(int driverId, bool availability)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "UPDATE drivers SET availability = @Availability WHERE DriverId = @DriverId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Availability", availability);
                command.Parameters.AddWithValue("@DriverId", driverId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


    }
}
