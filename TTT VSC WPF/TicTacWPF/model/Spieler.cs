using System;

namespace model
{
    public class Spieler : ISpieler
    {
        private Farbe Farbe;
        private int SpielerID;
        private String Spielername = "";
        private int Wins;
        public Farbe getSpielerfarbe()
        {
            return this.Farbe;
        }

        public int getSpielerID()
        {
            return this.SpielerID;
        }

        public string getSpielerName()
        {
            return this.Spielername;
        }

        public void setSpielerName(string spielerName)
        {
            this.Spielername = spielerName.Trim().Substring(0, Math.Min(12, spielerName.Trim().Length));
        }

        public void gewonnen()
        {
            Wins++;
        }

        public int gewonneneSpiele()
        {
            return Wins;
        }

        public Spieler(string Name, Farbe Farbe, int ID)
        {
            this.setSpielerName(Name);
            this.Farbe = Farbe;
            this.SpielerID = ID;
        }
    }
}
