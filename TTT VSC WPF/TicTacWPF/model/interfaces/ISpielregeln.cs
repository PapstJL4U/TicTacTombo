namespace model
{
    public interface ISpielregeln
    {
        bool istGueltigerZug(int row, int col, ISpielstein Stein);
        bool istGewonnen(Farbe Spielerfarbe);
    }
}
