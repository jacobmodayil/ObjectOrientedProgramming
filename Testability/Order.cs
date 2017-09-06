using System;

namespace Testability
{
    public class Order
    {
        public int Id { get; set; }
        public Shipment Shipment { get; set; }
        public float TotalPrice { get; set; }
        public DateTime DatePlaced { get; set; }

        public bool IsShipped => Shipment != null;
    }
}