using System;
using System.Net;
using System.Windows.Forms;
using System.Drawing;

namespace EZLib
{
    public class Startup
    {
        public static void authProgram(string programId)
        {
            apiAccess.authProgramApi(programId);
        }
    }
}