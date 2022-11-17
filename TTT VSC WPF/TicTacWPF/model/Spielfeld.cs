namespace model
{
    public class Spielfeld : ISpielfeld
    {
        private int ID;
        private int row = 3;
        private int col = 3;
        private ISpielsteinfeld[,] Feld;
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
            int id = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Feld[i, j] = new Spielsteinfeld(id);
                    id++;
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
