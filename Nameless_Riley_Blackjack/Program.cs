using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Nameless_Riley_Blackjack
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Privatelist<string> PlayerHand;
        }
    }
    {
internal class Privatelist<T>
    {
    }

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
