namespace Alibaba
{
    class User
    {
        private string userName { get; set; }

        EnumUserType type { get; set; }

        private string email { get; set; }

        private int wallet;

        private string avatar { get; set; }

        private string password { get; set; }



        void setUserName(string username)
        {
            this.userName = username;
        }

        public string getUserName()
        {
            return this.userName;
        }

        public void setEmail(string email)
        {
            this.email= email;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setAvatar(string avatar)
        {
            this.avatar= avatar;
        }

        public string getAvatar() { 
            return this.avatar;
        }

        public void setPassword(string password)
        {
            this.password=password;
        }

        public void setWallet(int price)
        {
            this.wallet= price;
        }

    }
}