using model;

namespace TicTacToe.controller
{
    public class CSpiel
    {
        ISpielfeld Spielfeld;
        ISpieler[] Spieler;
        ISpielregeln Spielregeln;
        int Spieleranzahl = 2;
        int AnDerReihe = 0;
        int max_id;
        int generate_Stein_ID = 0;
        Form1 MyForm = null;
        public CSpiel()
        {
            max_id = Spieleranzahl - 1;
            Spieler Spieler1 = new Spieler("Alice", Farbe.Lila, 0);
            Spieler Spieler2 = new Spieler("Bob", Farbe.Weiss, 1);
            Spieler = new Spieler[] { Spieler1, Spieler2 };
            int groesse = 3;
            Spieleranzahl = 2;
            AnDerReihe = 0;
            generate_Stein_ID = 0;
            Spielfeld = new Spielfeld(groesse, 0);
            Spielregeln = new Spielregeln(Spielfeld);

        }
        public CSpiel(Form1 Form) : this()
        {
            MyForm = Form;
            MyForm.setSpielernamen(Spieler[0], Spieler[1]);
        }

        public void neuesSpiel()
        {
            int groesse = 3;
            Spieleranzahl = 2;
            generate_Stein_ID = 0;
            Spielfeld = new Spielfeld(groesse, 0);
            Spielregeln = new Spielregeln(Spielfeld);
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
                    MyForm.setButton(row, col, far);
                    gewonnenesSpiel(Spieler[AnDerReihe]);
                }
                else
                {
                    generate_Stein_ID++;
                    MyForm.setButton(row, col, far);

                }

                AnDerReihe = (AnDerReihe + 1) % Spieleranzahl;
                MyForm.setArrow(AnDerReihe);
            }
            else
            {
                //Do nothing
            }
        }

        private void gewonnenesSpiel(ISpieler Spieler)
        {
            Spieler.gewonnen();
            MyForm.gewonnenesSpiel(Spieler.getSpielerName(), Spieler.getSpielerID(), Spieler.gewonneneSpiele());
        }


    }
}
