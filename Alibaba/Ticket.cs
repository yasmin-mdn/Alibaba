namespace Alibaba
{
    class Ticket
    {


        Passenger passenger;

        Trip trip;

        Seat seat;

        public void setPassenger(Passenger passenger)
        {
            this.passenger = passenger;
        }

        public void setTrip(Trip t)
        {
            this.trip = t;
        }

        public void setSeat(Seat seat)
        {
            this.seat = seat;
        }
    }
}