namespace Alibaba
{
    class Location
    {


        private string country;

        private string city;

        private string terminal;

        public void setCountry(string country)
        {
             this.country=country;
        }

        public string getCountry()
        {
            return this.country;
        }

        public void setCity(string city)
        {
            this.city=city;
        }

        public string getCity()
        {
            return this.city;
        }

        public void setTerminal(string terminal)
        {
            this.terminal=terminal;
        }

        public string getTerminal()
        {
            return this.terminal;
        }
    }
}