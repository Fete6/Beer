using System;
using System.Collections;
using System.Collections.Generic;

namespace Opgave_Beer
{
    internal class CompareBeerByVolumen : IComparer<Beer>
    {
        public CompareBeerByVolumen()
        {
        }


        public int Compare(Beer vol1, Beer vol2)
        {
            return vol1.Volumen.CompareTo(vol2.Volumen);
        }
    }
}