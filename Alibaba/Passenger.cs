using System;

namespace Alibaba
{
    class Passenger
    {
        string phoneNumber;

        string firstName;

        string lastName;

        string nationalId;

        bool gender;

        DateTime birthdate;

        public void setPhoneNumber(string phone)
        {
            this.phoneNumber = phone;
        }

        string getPhoneNumber()
        {
            return this.phoneNumber;
        }

        void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        string getFirstName()
        {
            return this.firstName;
        }

        void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        string getLastName()
        {
            return this.lastName;
        }

        void setNationalI(string nationalId)
        {
            this.nationalId = nationalId;
        }

        string getnationalId()
        {
            return this.nationalId;
        }

        void setGender(bool gender)
        {
            this.gender = gender;
        }

        bool getGender()
        {
            return this.gender;
        }

        void setBirthdate(DateTime birthdate)
        {
            this.birthdate = birthdate;
        }

        DateTime getBirthdate()
        {
            return this.birthdate;
        }


    }
}