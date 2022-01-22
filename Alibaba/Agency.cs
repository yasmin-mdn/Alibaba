using System.Linq;

namespace Alibaba
{
    class Agency
    {
        int registrationNumber;

        string name;

        string[] gallery;

        string website;

        string[] telephones;

        string bankAccount;

        int getRegistrationNumber()
        {
            return this.registrationNumber;
        }

        void setName(string name)
        {
            this.name = name;
        }

        string getName()
        {
            return this.name;
        }

        void addImage(string adress)
        {
            this.gallery.Append(adress);
        }

        void removeImage(string adress)
        {
            this.gallery.Aggregate(adress, (current, t) => current.Replace(t, string.Empty));
        }

        string[] getGallery()
        {
            return this.gallery;
        }

        void addTelephone(string telephone)
        {
            this.telephones.Append(telephone);
        }

        void removeTelephone(string telephone)
        {
            this.gallery.Aggregate(telephone, (current, t) => current.Replace(t, string.Empty));
        }

        string[] getTelephones()
        {
            return this.telephones;
        }

        void setBankAccount(string bankAccount)
        {
            this.bankAccount = bankAccount;
        }

        string getbankAccount()
        {
            return this.bankAccount;
        }

    }
}