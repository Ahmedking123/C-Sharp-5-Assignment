using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization.Metadata;

namespace C_Sharp_5__Assignment
{
    #region Fifth Question

    internal struct DeliveryCenter
    {
        private Shipment[] shipments;

        public DeliveryCenter()
        {
            shipments = new Shipment[10];
        }
        public Shipment this[int index]
        {
            get
            {
                if (shipments == null && index < 0 || index > 9)
                {
                    return default;
                }
                return shipments[index];
            }
            set
            {
                if (shipments != null && index > 0 && index < 10)
                {
                    shipments[index] = value;
                }
            }
        }
        public Shipment this[string trackingCode]
        {
            get
            {
                if (shipments != null && !string.IsNullOrEmpty(trackingCode))
                {
                    for (int i = 0; i < shipments.Length; i++)
                    {
                        if (shipments[i].TrackingCode == trackingCode)
                        {
                            return shipments[i];
                        }
                    }
                }
                return default;
            }
        }
        public bool AddShipment(Shipment shipment)
        {
            if (shipments != null)
            {
                for (int i = 0;i < shipments.Length;i++)
                {
                    if (shipments[i].TrackingCode == null)
                    {
                        shipments[i] = shipment;
                        return true;
                    }
                }
            }
            return false;
        }
    }

    #endregion
}
