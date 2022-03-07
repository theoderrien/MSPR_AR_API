using System.Collections.Generic;

namespace API_Hubspot_V2019
{
    public class ContactHubspot
    {
        public Dictionary<string, object> properties { get; set; }

        public ContactHubspot()
        {
            properties = new Dictionary<string, object>();

        }
        public ContactHubspot(string email, string firstname)
            : this()
        {
            properties.Add("email", email);
            properties.Add("firstname", firstname);
        }
    }
}
