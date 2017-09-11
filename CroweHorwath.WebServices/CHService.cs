using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CroweHorwath.WebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CHService : ICHService
    {
        public string GetData()
        {
            return "Hello World!";
        }
        public string GetUserData(string value)
        {
            return string.Format("You entered: {0}", value);
        }
        
    }
}
