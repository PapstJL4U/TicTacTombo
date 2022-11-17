using model;

namespace model
{
    public interface ISpielsteinfeld
    {
        int getSpielsteinfeldID();
        bool ist_freies_feld();
        bool lege_Spielstein(ISpielstein Stein);
        ISpielstein getSpielstein();
    }
}
