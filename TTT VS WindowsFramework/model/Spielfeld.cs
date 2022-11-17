namespace model
{
    public class Spielfeld : ISpielfeld
    {
        int ID;
        int row = 3;
        int col = 3;
        ISpielsteinfeld[,] Feld;
        public Spielfeld(int Groesse, int ID):this(Groesse, Groesse, ID)
        {
        }

        public Spielfeld(int row, int col, int ID){
            this.ID = ID;
            this.row = row;
            this.col = col;
            Feld = new ISpielsteinfeld[row, col];
            initFeld();
        }

        private void initFeld()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Feld[i, j] = new Spielsteinfeld(ID);
                }
            }
        }
        public int getSpielfeldGroesse()
        {
            return row;
        }

        public int getSpielfeldID()
        {
            return ID;
        }

        public ISpielstein getSpielstein(int row, int col)
        {
            return Feld[row, col].getSpielstein();
        }

        public bool setSpielstein(int row, int col, ISpielstein Stein)
        {
            return Feld[row, col].lege_Spielstein(Stein);
        }
    }
}
