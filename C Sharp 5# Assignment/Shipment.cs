using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_5__Assignment
{
    #region Fourth Quesion

    internal struct Shipment
    {
        private string _trackingCode;

        public string TrackingCode
        {
            get
            {
                return _trackingCode;
            }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _trackingCode = value;
                }
            }
        }
        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _description = value;
                }
            }
        }
        private double _weight;
        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
            }
        }
        private double _DeliveryFee;
        public double DeliveryFee
        {
            get
            {
                return _DeliveryFee;
            }
            set
            {
                if (value > 0)
                {
                    _DeliveryFee = value;
                }
            }
        }
        public DeliveryAddress Destination { get; set; }

        public double EstimatedCost => DeliveryFee + (Weight * 5);

        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = default;
        }
        public Shipment(string trackingCode,string description,double weight,double delivaryFee,DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = delivaryFee;
            Destination = destination;
        }

        public void UpdateDelivaryFee(double newDelivaryFee)
        {
            if (newDelivaryFee > 0)
            {
                DeliveryFee = newDelivaryFee;
            }
        }
        public string PrintShipment()
        {
            return $"""
                {TrackingCode} Tracking Code:
                {Description} Description:
                Weight: {Weight}
                Delivery Fee: {DeliveryFee}
                Destination: {Destination.GetFullAddress()}
                Estimated Cost: {EstimatedCost} EGP
                """;
        }
    }
    #endregion
}