using model;
namespace TicTacWPF
{
    public class Controller_Spiel
    {
        private ISpielfeld Spielfeld;
        private ISpieler[] Spieler;
        private ISpielregeln Spielregeln;
        private int Spieleranzahl = 2;
        private int AnDerReihe = 0;
        private int max_id, row, col, win;
        private int generate_Stein_ID = 0;
        private MainWindow MyWindow = null;
        public Controller_Spiel():this(null, 3, 3,3)
        {
        }
        public Controller_Spiel(MainWindow mwd) : this(mwd, 3,3,3)
        {            
        }

        public Controller_Spiel(MainWindow mwd, int prow, int pcol, int pwin){

            row = prow;
            col = pcol;
            win = pwin;
            MyWindow = mwd;
            max_id = Spieleranzahl - 1;
            Spieler Spieler1 = new Spieler("Alice Little", Farbe.Blau, 0);
            Spieler Spieler2 = new Spieler("Cassandra Cain", Farbe.Weiss, 1);
            Spieler = new Spieler[] { Spieler1, Spieler2 };
            Spieleranzahl = 2;
            AnDerReihe = 0;
            generate_Stein_ID = 0;
            Spielfeld = new Spielfeld(row, col, 0);
            Spielregeln = new Spielregeln(row, col, Spielfeld, win);
        
            MyWindow.setSpielernamen(Spieler[0].getSpielerName(), Spieler[1].getSpielerName());
            MyWindow.setSpielerFarbe(Spieler[0].getSpielerfarbe(), Spieler[1].getSpielerfarbe());
            MyWindow.setGoal(win);
        }

        public void neuesSpiel()
        {
            Spieleranzahl = 2;
            generate_Stein_ID = 0;
            Spielfeld = new Spielfeld(row, col, 0);
            Spielregeln = new Spielregeln(row, col,Spielfeld, win);
            MyWindow.setGoal(win);
        }

        public void pressedButton(int row, int col)
        {
            Farbe far = Spieler[AnDerReihe].getSpielerfarbe();
            int id = generate_Stein_ID;
            ISpielstein Stein = new Spielstein(far, id);
            if (Spielregeln.istGueltigerZug(row, col, Stein))
            {
                if (Spielregeln.istGewonnen(far))
                {
                    MyWindow.setButton(row, col, far);
                    gewonnenesSpiel(Spieler[AnDerReihe]);
                }
                else
                {
                    generate_Stein_ID++;
                    MyWindow.setButton(row, col, far);

                }

                AnDerReihe = (AnDerReihe + 1) % Spieleranzahl;
                MyWindow.setArrow(AnDerReihe);
            }
            else
            {
                //Do nothing
            }
        }

        private void gewonnenesSpiel(ISpieler Spieler)
        {
            Spieler.gewonnen();
            MyWindow.gewonnenesSpiel(Spieler.getSpielerName(), Spieler.getSpielerID(), Spieler.gewonneneSpiele());
        }


    }
}
