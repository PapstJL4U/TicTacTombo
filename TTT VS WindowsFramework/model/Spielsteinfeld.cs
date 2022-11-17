﻿namespace model
{
    public class Spielsteinfeld : ISpielsteinfeld
    {
        int SpielsteinfeldID;
        bool istFrei = true;
        ISpielstein Spielstein = null;

        public Spielsteinfeld(int ID)
        {
            this.SpielsteinfeldID = ID;
        }

        public ISpielstein getSpielstein()
        {
            return this.Spielstein;
        }

        public int getSpielsteinfeldID()
        {
            return this.SpielsteinfeldID;
        }

        public bool ist_freies_feld()
        {
            return istFrei;
        }

        public bool lege_Spielstein(ISpielstein Stein)
        {
            if (istFrei)
            {
                this.Spielstein = Stein;
                this.istFrei = false;
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
