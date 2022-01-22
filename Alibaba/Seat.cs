namespace Alibaba
{
    class Seat
    {



        private int seat_number;

        private EnumSeatStatus status;

        public int getSeatNumber()
        {
            return this.seat_number;
        }

        public void setStatus(EnumSeatStatus status)
        {
            this.status = status;
        }

        public EnumSeatStatus getStatus()
        {
            return this.status;
        }



    }
}