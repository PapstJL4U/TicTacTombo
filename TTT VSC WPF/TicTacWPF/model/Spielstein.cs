namespace model
{
    public class Spielstein : ISpielstein
    {
        private Farbe Farbe;
        private int ID;
        public Spielstein(Farbe Farbe, int ID)
        {
            this.Farbe = Farbe;
            this.ID = ID;
        }
        public Farbe getSteinfarbe()
        {
            return this.Farbe;
        }
        public int getSteinID()
        {
            return this.ID;
        }
    }
}
