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
            try
            {
                throw new DivideByZeroException();
            }
            catch (DivideByZeroException ex)
            {
                Form formControl = new EZLib.UserControls.Error_Messages.formMessage(ex.GetType().Name, ex.Message);

                formControl.StartPosition = FormStartPosition.CenterScreen;
                formControl.ShowIcon = false;
                formControl.ShowInTaskbar = false;
                
                formControl.ShowDialog();
            }
        }
    }
}