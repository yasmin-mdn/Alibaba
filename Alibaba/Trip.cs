using System;

namespace Alibaba
{
    class Trip
    {
       private Vehicle vehicle;

        private Location source;

        private Location destination;

        private DateTime departure_time;

        private DateTime arrival_time;

        private Seat seats;

        private int price;

        private Agency agency;



        public void setVehicle(Vehicle vehicle) {
            this.vehicle=vehicle;
        }

        public Vehicle getVehicle()
        {
            return this.vehicle;
        }

        public void setSource(Location src)
        {
            this.source=src;
        }

        public  Location getSource() {
            return this.source ;
         }

        public void setDestination(Location dst) { 
            this.destination=dst;
        }

        public Location getDestination() {
            return this.destination;
         }

        public void setDepartureTime(DateTime departure) {
            this.departure_time=departure;
         }

        public DateTime getDepartureTime() { 
            return this.departure_time;
        }

        public void setArrivalTime(DateTime arrival)
        {
            this.arrival_time=arrival;
        }

        public void setPrice(int price)
        {
            this.price=price;
        }

        public int getPrice() { 
            return this.price;
        }

        public void setAgency(Agency agency)
        {
            this.agency=agency;
        }

        public Agency getAgency()
        {
            return this.agency;
        }

    }
}