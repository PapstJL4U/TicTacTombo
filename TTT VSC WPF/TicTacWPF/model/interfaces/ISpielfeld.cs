namespace model
{
    public interface ISpielfeld
    {
        int getSpielfeldID();
        int getSpielfeldGroesse();
        ISpielstein getSpielstein(int row, int col);
        bool setSpielstein(int row, int col, ISpielstein Stein);
    }
}
