using System;

namespace model
{
    public class Spielregeln : ISpielregeln
    {
        int max_row = 3;
        int max_col = 3;
        int win_length = 3;
        ISpielfeld Feld = null;
        public Spielregeln(int row, int col, ISpielfeld Feld, int win)
        {
            max_row = row;
            max_col = col;
            win_length = win;
            this.Feld = Feld;
        }

        public Spielregeln(int groesse, ISpielfeld Feld) : this(groesse, groesse, Feld, groesse)
        {
        }

        public Spielregeln(ISpielfeld Feld) : this(3, 3, Feld, 3)
        {
        }

        public bool istGewonnen(Farbe Spielerfarbe)
        {
            return Horizontal(Spielerfarbe) || Vertical(Spielerfarbe) || Diagonal(Spielerfarbe);
        }

        public bool istGueltigerZug(int row, int col, ISpielstein Stein)
        {
            return Feld.setSpielstein(row, col, Stein);
        }

        private bool Horizontal(Farbe Spielerfarbe)
        {
            bool erfolg = false;
            for (int r = 0; r < max_row; r++)
            {
                int in_a_row = 0;
                for (int c = 0; c < max_col; c++)
                {
                    ISpielstein Stein = Feld.getSpielstein(r, c);

                    if (Stein == null || Stein.getSteinfarbe() != Spielerfarbe)
                    {
                        in_a_row = 0;
                    }
                    else
                    {
                        in_a_row++;
                    }

                    if (in_a_row >= win_length)
                    {
                        break;
                    }
                }
                if (in_a_row >= win_length)
                {
                    erfolg = true;
                    break;
                }
            }
            return erfolg;
        }

        private bool Vertical(Farbe Spielerfarbe)
        {
            bool erfolg = false;
            for (int c = 0; c < max_col; c++)
            {
                int in_a_col = 0;
                for (int r = 0; r < max_row; r++)
                {
                    ISpielstein Stein = Feld.getSpielstein(r, c);

                    if (Stein == null || Stein.getSteinfarbe() != Spielerfarbe)
                    {
                        in_a_col = 0;
                    }
                    else
                    {
                        in_a_col++;
                    }
                    if (in_a_col >= win_length)
                    {
                        erfolg = true;
                        break;
                    }
                }
                if (in_a_col >= win_length)
                {
                    erfolg = true;
                    break;
                }
            }
            return erfolg;
        }

        private bool Diagonal(Farbe Spielerfarbe)
        {
            return diagonal_down(Spielerfarbe) || diagonal_up(Spielerfarbe);
        }

        private bool diagonal_up(Farbe Spielerfarbe)
        {
            bool erfolg = false;
            int min_index_row = win_length - 1;
            int max_index_col = max_col - win_length;
            //loop through the starting index
            for (int r = max_row - 1; r >= min_index_row; r--)
            {
                for (int c = 0; c <= max_index_col; c++)
                {
                    int in_a_dia = 0;
                    //find the diagonal down
                    for (int dt = 0; dt < win_length; dt++)
                    {
                        ISpielstein Stein = Feld.getSpielstein(r - dt, c + dt);
                        if (Stein == null || Stein.getSteinfarbe() != Spielerfarbe)
                        {
                            in_a_dia = 0;
                        }
                        else
                        {
                            in_a_dia++;
                        }

                        if (in_a_dia >= win_length)
                        {
                            erfolg = true;
                            r = min_index_row - 1;
                            c = max_index_col + 1;
                            break;
                        }
                    }
                }
            }

            return erfolg;
        }


        private bool diagonal_down(Farbe Spielerfarbe)
        {

            bool erfolg = false;
            int max_index_row = max_row - win_length;
            int max_index_col = max_col - win_length;
            //loop through the starting index
            for (int r = 0; r <= max_index_row; r++)
            {
                for (int c = 0; c <= max_index_col; c++)
                {

                    int in_a_dia = 0;
                    //find the diagonal down
                    for (int dt = 0; dt < win_length; dt++)
                    {
                        ISpielstein Stein = Feld.getSpielstein(r + dt, c + dt);
                        if (Stein == null || Stein.getSteinfarbe() != Spielerfarbe)
                        {
                            in_a_dia = 0;
                        }
                        else
                        {
                            in_a_dia++;
                        }

                        if (in_a_dia >= win_length)
                        {
                            erfolg = true;
                            r = max_index_row + 1;
                            c = max_index_col + 1;
                            break;
                        }
                    }

                }
            }

            return erfolg;
        }
    }

}
