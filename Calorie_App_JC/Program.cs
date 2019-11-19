using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCounter
{
    static class Program
    {
        // Variable to run program
        public static bool runProgram = true;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Continue to loop until application is quit
            do
            {
                Application.Run(new frmLogin());

                // Launch frmSignUp if new user
                if (frmLogin.UserRequiresSignUp)
                {
                    Application.Run(new frmSignUp());
                }

                // Launch main screen if user provides proper credentials
                if (frmLogin.UserSuccessfullyAuthenticated)
                {
                    Application.Run(new frmMainScreen());
                }
            } while (runProgram);
        }
    }
}