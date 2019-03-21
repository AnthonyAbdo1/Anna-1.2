using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anna
{
    class Anna
    {
        public string BasicGreeting()
        {
            TimeSpan noon = new TimeSpan(12, 0, 0); //12 o'clock
            TimeSpan now = DateTime.Now.TimeOfDay;
            var afternoonGreeting = "Good Evening";
            var greeting = "Good Morning";

            if ((now > noon))
            {
                return afternoonGreeting;
            }

            else
            {
                return greeting;
            }

            

        }
    }
}
