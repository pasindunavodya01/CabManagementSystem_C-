using System;
using WinFormsApp3;

namespace CabManagementSystem
{
    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public Driver Driver { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Destination { get; set; }
        public string CurrentLocation { get; set; }
        public Order(int orderId, Customer customer, Driver driver, DateTime date, string currentLocation, string destination)
        {
            OrderId = orderId;
            Customer = customer;
            Driver = driver;
            Date = date;
            Name = Name;
            CurrentLocation = currentLocation;
            Destination = destination;
        }

        public string GetDetails()
        {
            return $"Order ID: {OrderId}, Customer: {Customer.Name}, Driver: {Driver.Name}, Date: {Date}";
        }
    }
}
