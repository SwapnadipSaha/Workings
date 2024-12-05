using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace ASPDotNET_Tutorial_for_Beginners
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

            //Code that runs on Application Startup.
            //This event gets fired if the application is not already running.
            //The first request of a webform of an application reached IIS, and loads the assembly into the memory.

            Application["TotalApplications"] = 0;
            Application["TotalUserSessions"] = 0;
            Application["TotalApplications"] = (int)Application["TotalApplications"] + 1;

            ScriptManager.ScriptResourceMapping.AddDefinition(
        "jquery",
        new ScriptResourceDefinition
        {
            Path = "https://code.jquery.com/jquery-3.6.0.min.js"
        });
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            ///Code that runs when new session  has been created.
            ///when a new user logged into the system or connects to the application.
            ///A session is considered as a unique instance of a browser with a unique session id.
            Application["TotalUserSessions"] = (int)Application["TotalUserSessions"] + 1;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            //Code that runs when an unhandled error occurs.
            //Use to handled the exception and log into a database or eventviewer.
        }

        protected void Session_End(object sender, EventArgs e)
        {
            ///Code that runs when new session  has been ends or a session timedout.
            ///This event raised only when the sessionstate mode is set to InProc in web.config file.
            ///If it set to StateServer or anything else, This won't work.
            ///
            Application["TotalUserSessions"] = (int)Application["TotalUserSessions"] - 1;

        }

        protected void Application_End(object sender, EventArgs e)
        {
            //Code that runs on Application shutdown.
            //There are no more actgive sessions.
            //The last active session has been expired.
        }
    }
}