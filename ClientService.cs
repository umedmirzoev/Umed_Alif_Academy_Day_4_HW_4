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
            if (firstName is { Length: 0} || lastName is { Length: 0})
            {
                throw new ArgumentException("This field cannot be empty. It is a required field.");
            }

            Client client = new Client
            {
                ClientId = clientId,
                FirstName = firstName,
                LastName = lastName
            };

            return client;
        }
    }
}
