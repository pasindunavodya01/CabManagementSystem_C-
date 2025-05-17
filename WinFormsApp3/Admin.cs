using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CabManagementSystem
{
    public class Admin
    {
        private string connectionString;
        private object CustomerId;

        public Admin(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddCar(Car car)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO cars (model, PlateNumber, availability) VALUES (@Model, @PlateNumber, @Availability)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Model", car.Model);
                command.Parameters.AddWithValue("@PlateNumber", car.PlateNumber);
                command.Parameters.AddWithValue("@Availability", car.Availability);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void RemoveCar(int carId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM cars WHERE CarId = @CarId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@CarId", carId);
                connection.Open();
                command.ExecuteNonQuery();
            }
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
                    int carId = Convert.ToInt32(reader["CarId"]);
                    string model = reader["model"].ToString();
                    string plateNumber = reader["PlateNumber"].ToString();
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
                    int driverId = Convert.ToInt32(reader["DriverId"]);
                    string name = reader["name"].ToString();
                    string contactNumber = reader["ContactNumber"].ToString();
                    bool availability = Convert.ToBoolean(reader["availability"]);
                    drivers.Add(new Driver(driverId, name, contactNumber, availability));
                }
            }
            return drivers;
        }
        public void AddDriver(Driver driver)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO drivers (name, ContactNumber, availability) VALUES (@Name, @ContactNumber, @Availability)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", driver.Name);
                command.Parameters.AddWithValue("@ContactNumber", driver.ContactNumber);
                command.Parameters.AddWithValue("@Availability", driver.Availability);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void RemoveDriver(int driverId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM drivers WHERE DriverId = @DriverId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@DriverId", driverId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Order> ViewOrders()
        {
            List<Order> orders = new List<Order>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = @"SELECT o.OrderId, o.OrderDate, o.CurrentLocation, o.Destination, 
                                c.CustomerId, c.Name AS CustomerName, c.ContactNumber AS CustomerContact, 
                                d.DriverId, d.Name AS DriverName, d.ContactNumber AS DriverContact 
                         FROM orders o 
                         JOIN customers c ON o.CustomerId = c.CustomerId 
                         JOIN drivers d ON o.DriverId = d.DriverId
                         WHERE o.CustomerId = @CustomerId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerId", this.CustomerId);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int orderId = Convert.ToInt32(reader["OrderId"]);
                    DateTime orderDate = Convert.ToDateTime(reader["OrderDate"]);
                    string currentLocation = reader["CurrentLocation"].ToString();
                    string destination = reader["Destination"].ToString();

                    int customerId = Convert.ToInt32(reader["CustomerId"]);
                    string customerName = reader["CustomerName"].ToString();
                    string customerContact = reader["CustomerContact"].ToString();

                    Customer customer = new Customer(customerId, customerName, customerContact, currentLocation , destination , connectionString); // Adjust constructor if needed

                    int driverId = Convert.ToInt32(reader["DriverId"]);
                    string driverName = reader["DriverName"].ToString();
                    string driverContact = reader["DriverContact"].ToString();

                    Driver driver = new Driver(driverId, driverName, driverContact, true); // Adjust constructor if needed

                    orders.Add(new Order(orderId, customer, driver, orderDate, currentLocation, destination)); // Adjust constructor if needed
                }
            }
            return orders;
        }



        public bool CheckCarAvailability(int carId)
        {
            bool availability = false;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT availability FROM cars WHERE CarId = @CarId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CarId", carId);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        availability = Convert.ToBoolean(result);
                    }
                }
            }

            return availability;
        }

        // Method to toggle car availability
        public bool ToggleCarAvailability(int carId)
        {
            bool availability = !CheckCarAvailability(carId); // Get the current availability and toggle it
            UpdateCarAvailability(carId, availability); // Update the availability in the database
            return availability;
        }

        // Method to update car availability
        public void UpdateCarAvailability(int carId, bool availability)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "UPDATE cars SET availability = @Availability WHERE CarId = @CarId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Availability", availability);
                    command.Parameters.AddWithValue("@CarId", carId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public bool GetCarAvailability(int carId)
        {
            bool availability = false;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT availability FROM cars WHERE CarId = @CarId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CarId", carId);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        availability = Convert.ToBoolean(result);
                    }
                }
            }

            return availability;
        }
        public bool CheckDriverAvailability(int driverId)
        {
            bool availability = false;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT availability FROM drivers WHERE DriverId = @DriverId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DriverId", driverId);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        availability = Convert.ToBoolean(result);
                    }
                }
            }

            return availability;
        }

        // Method to toggle driver availability
        public bool ToggleDriverAvailability(int driverId)
        {
            bool availability = !CheckDriverAvailability(driverId); // Get the current availability and toggle it
            UpdateDriverAvailability(driverId, availability); // Update the availability in the database
            return availability;
        }

        // Method to update driver availability
        public void UpdateDriverAvailability(int driverId, bool availability)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "UPDATE drivers SET availability = @Availability WHERE DriverId = @DriverId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Availability", availability);
                    command.Parameters.AddWithValue("@DriverId", driverId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool GetDriverAvailability(int driverId)
        {
            bool availability = false;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT availability FROM drivers WHERE DriverId = @DriverId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DriverId", driverId);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        availability = Convert.ToBoolean(result);
                    }
                }
            }

            return availability;
        }
        public List<Driver> GetAllDrivers()
        {
            List<Driver> drivers = new List<Driver>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM drivers";
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int driverId = Convert.ToInt32(reader["DriverId"]);
                    string name = reader["name"].ToString();
                    string contactNumber = reader["ContactNumber"].ToString();
                    bool availability = Convert.ToBoolean(reader["availability"]);
                    drivers.Add(new Driver(driverId, name, contactNumber, availability));
                }
            }
            return drivers;
        }
        public List<Car> GetAllCars()
        {
            List<Car> cars = new List<Car>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM cars";
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
    }
}
