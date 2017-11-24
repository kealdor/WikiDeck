using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WikiDeck
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
            Decks decks = new Decks();
            decks.LoadAsync("http://magicduels.wikia.com/").GetAwaiter().GetResult();
            Application.Run(new FormMain(decks));
        }
    }
}
