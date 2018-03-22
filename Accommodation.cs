using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanUppg3
{
    class Accommodation
    {
            int Room_id { get; set; }
            int Host_id { get; set; }
            string Room_type { get; set; }
            string Borough { get; set; }
            string Neighbourhood { get; set; }
            int Reviews { get; set; }
            double Overall_satisfaction { get; set; }
            int Accomodates { get; set; }
            int Bedrooms { get; set; }
            int Price { get; set; }
            int Minstay { get; set; }
            double Latitude { get; set; }
            double Longitude { get; set; }
            string Last_modified { get; set; }

            public Accommodation(int room_id, int host_id, string room_type, string borough, string neighbourhood, int reviews, double overall_satisfaction, int accomodates, int bedrooms, int price, int minstay, double latitude, double longitude, string last_modified)
            {
                this.Room_id = room_id;
                this.Host_id = host_id;
                this.Room_type = room_type;
                this.Borough = borough;
                this.Neighbourhood = neighbourhood;
                this.Reviews = reviews;
                this.Overall_satisfaction = overall_satisfaction;
                this.Accomodates = accomodates;
                this.Bedrooms = bedrooms;
                this.Price = price;
                this.Minstay = minstay;
                this.Latitude = latitude;
                this.Longitude = longitude;
                this.Last_modified = last_modified;
            }
    }
}
