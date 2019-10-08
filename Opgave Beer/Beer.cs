using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_Beer
{
    class Beer : IComparable
    {
        public enum BeerType
        { Blanding, Lager, Pilsner, Münchener, Wiener, Dortmunder, Bock, DobbelBock, Porter  }

        private string _navn;
        private BeerType _slags;
        private float _procent;
        private int _volumen;

        public string Navn
        {
            set { _navn = value; }
            get { return _navn; }
        }
        public BeerType Slags
        {
            set { _slags = value; }
            get { return _slags; }
        } 
        public float Procent
        {
            set { _procent = value; }
            get { return _procent; }
        }
        public int Volumen
        {
            set { _volumen = value; }
            get { return _volumen; }
        }

        public Beer()
        {

        }

        public Beer(string Name1, BeerType Slags1, float Procent1, int Volumen1  )
        {
            Navn = Name1;
            Slags = Slags1;
            Procent = Procent1;
            Volumen = Volumen1;
        }
        public float GetUnits()
        {
            float Genstande = (Volumen * Procent) / 150;
            return Genstande;
        }

        public int CompareTo(object obj)
        {
            int result = this.Volumen - ((Beer)obj).Volumen;
            if (result != 0)
            {
                return result;
            }
            else
            {
                return this.Navn.CompareTo(((Beer)obj).Navn);
            }



        }

        public static Beer operator+(Beer b1, Beer b2)
        {
            Beer Blanding = new Beer();
            Blanding.Slags = BeerType.Blanding;
            Blanding.Navn = b1.Navn + " " + b2.Navn;
            Blanding.Procent = ((b1.Volumen * b1.Procent) + (b2.Volumen * b2.Procent)) / (b1.Volumen + b2.Volumen);
            Blanding.Volumen = b1.Volumen + b2.Volumen;

            return Blanding;



        }







        public override string ToString()
        {
            return $"Din øl hedder {Slags}\nDen kommer fra {Navn}\nDer er {Procent} procent alkohol i flasken, og den indeholder {Volumen} centiliter væske ";
        }

    }


}
