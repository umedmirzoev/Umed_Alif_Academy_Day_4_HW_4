using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umed_Alif_Academy_Day_4_HW_4
{
    public class ClientService
    {
        public Client CreateClient(int clientId, string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("This field cannot be empty. It is a required field.");
            }

            Client client = new Client
            {
                ClientID = clientId,
                FirstName = firstName,
                LastName = lastName
            };

            return client;
        }
    }
}
