using Fiddler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: Fiddler.RequiredVersion("2.3.5.0")]

namespace PasswordListener
{
    public class Violin : IAutoTamper    
    {
        string sUserAgent = "";

        public Violin()
        {
            sUserAgent = "Violin";
        }

        public void OnLoad()
        {
            /* Load your UI here */
        }

        public void OnBeforeUnload()
        {

        }

        public void AutoTamperRequestBefore(Session oSession)
        {
            oSession.oRequest["User-Agent"] = sUserAgent;
        }

        public void AutoTamperRequestAfter(Session oSession)
        {

        }

        public void AutoTamperResponseBefore(Session oSession)
        {

        }

        public void AutoTamperResponseAfter(Session oSession)
        {

        }

        public void OnBeforeReturningError(Session oSession)
        {

        }
    }
}
