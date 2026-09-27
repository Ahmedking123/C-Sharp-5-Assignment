
namespace C_Sharp_5__Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Question
            //The original value will stay the same since struct is a value type
            //the value of the original variable will change since class is a reference type
            #endregion

            #region Second Question
            //1- any changes happen with the orignal code will effect out side the struct  2- no validation for the data 3- no protection for the data
            //flexibilty for the code and easier future maintenance 
            #endregion
            #region Sixth question
            #region First Point

            DeliveryCenter deliveryCenter = new DeliveryCenter();

            #endregion

            #region Second Point
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Enter Shipment {i} data");
                Console.Write("Tracking Code: ");
                string trackingCode = Console.ReadLine();
                Console.Write("Description: ");
                string description = Console.ReadLine();
                Console.Write("Weight: ");
                double weight = double.Parse(Console.ReadLine());
                Console.Write("Delivary Fee: ");
                double deliveryFee = double.Parse(Console.ReadLine());
                Console.Write("City: ");
                string city = Console.ReadLine();
                Console.Write("Street: ");
                string street = Console.ReadLine();
                Console.Write("Building Number: ");
                int buildingNumber = int.Parse(Console.ReadLine());
                DeliveryAddress deliveryAddress = new DeliveryAddress(city, street, buildingNumber);
                Shipment shipment = new Shipment(trackingCode, description, weight, deliveryFee, deliveryAddress);
                #region Third Point

                deliveryCenter.AddShipment(shipment);


                #endregion            }
            }
            #endregion

            #region Fourth Point

            for (int i = 0; i < 3; i++)
            {
                deliveryCenter[i].PrintShipment();
            }

            #endregion
            #region Fifth Point

            Console.WriteLine("Enter a tracking Code");
            string trackingCode = Console.ReadLine();

            #endregion

            #region Sixth Point

            var shipment = deliveryCenter[trackingCode];
            if (shipment.TrackingCode == null)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                shipment.PrintShipment();
            }

            #endregion

            #region Seventh Point 
            Console.WriteLine("---- Struct Copy Test ----");
            Console.WriteLine($"Original Address: {deliveryCenter[0].Destination.GetFullAddress()}");
            deliveryCenter[0] = deliveryCenter[1];
            Console.WriteLine($"Copied Address: {deliveryCenter[0].Destination.GetFullAddress()}");
            

            #endregion

            #endregion
        }
    }
}
