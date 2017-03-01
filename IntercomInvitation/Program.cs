using System;
using IntercomInvitation.View;
using System.Windows.Forms;

namespace IntercomInvitation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InvitedCustomersView());
        }
    }
}
