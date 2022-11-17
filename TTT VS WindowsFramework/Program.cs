using System;
using System.Windows.Forms;
using TicTacToe.controller;

namespace TicTacToe
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 MyForm = new Form1();
            CSpiel Spiel = new CSpiel(MyForm);
            MyForm.setController(Spiel);

            Application.Run(MyForm);
        }
    }
}
