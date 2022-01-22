namespace Alibaba
{
    class Vehicle
    {



        private EnumVehicleType type;

        private string manufacturer;

        private string model;

        private int capacity;

        public void setManufacturer(string manufacturer)
        {
            this.manufacturer = manufacturer;
        }

        public string getManufacturer()
        {
            return this.manufacturer;
        }

        public void setModel(string model)
        {
            this.model = model;
        }

        public string getModel()
        {
            return this.model;
        }

        public void setCapacity(int capacity)
        {
            this.capacity = capacity;
        }

        public int getCapacity()
        {
            return this.capacity;
        }

    }
}