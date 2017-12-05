using System;
using System.Windows.Forms;

namespace WikiDeck
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string deckPrefix;
            string deckListsPageName;
            if (args.Length > 0)
            {
                deckPrefix = "TestDecks/";
                deckListsPageName = "TestDecklists";
            }
            else
            {
                deckPrefix = "Decks/";
                deckListsPageName = "Decklists";
            }
            Application.Run(new FormMain(deckPrefix, deckListsPageName));
        }
    }
}
