

using Practice.Common;

namespace Practice.HR
{

    class ClientBuilder : IClientBuilder
    {
        protected Client ClientToBuild { get; set; }

        public IClient Build()
        {
            var ClientReference = ClientToBuild;
            ClientToBuild = null;
            return ClientReference;
        }

        public IClientBuilder Discount(float discount)
        {
            isExist();
            ClientToBuild.Discount = discount;
            return this;
        }

        public IClientBuilder Name(IName name)
        {
            isExist();
            ClientToBuild.Name = new Common.Name(name); 
            return this;
        }

        public IClientBuilder Name(string name, string surname, string patronymic)
        {
            isExist();
            ClientToBuild.Name = new Common.Name(name, surname, patronymic);
            return this;
        }

        private void isExist() {
            if (ClientToBuild is null) 
            {
                ClientToBuild = new Client();
            }
        }
    }
}