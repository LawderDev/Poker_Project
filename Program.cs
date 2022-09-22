using System;
using System.IO;
using System.Windows.Forms;

namespace PokerProject
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
            RuleSet theRules = new RuleSet("../../rules.xml");
            string currentDirectory = Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "");

            // The dialog for choose a rule
            OpenFileDialog open = new OpenFileDialog
            {
                InitialDirectory = currentDirectory,
                Filter = "Fichier (xml)|*.xml",
                Title = "Choisir un fichier de règles au format xml contenant \"rules\" dans le nom du fichier.",
            };
            
            open.ShowDialog();

            if (open.FileName.Contains("rules.xml"))
                theRules = new RuleSet(open.FileName);
            else
            {
                Error error = new Error();
                error.TopMost = true;
                error.ShowDialog();
            }


            // 2 - SetupView

            ExampleSetupView setupView = new ExampleSetupView(theRules);
            setupView.TopMost = true;
            if (setupView.ShowDialog() != DialogResult.OK)
            {
                return;
            }


            GameView theView = new GameView(theRules);
            GameControler.Initialize(theRules, theView);
            Application.Run(theView);
        }
    }
}
