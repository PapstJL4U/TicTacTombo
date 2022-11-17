using System;

namespace model
{
    public interface ISpieler
    {
        String getSpielerName();
        void setSpielerName(String spielerName);
        Farbe getSpielerfarbe();
        int getSpielerID();
        void gewonnen();

        int gewonneneSpiele();

    }
}
