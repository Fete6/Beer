using System;
using System.Collections;
using System.Collections.Generic;

namespace Opgave_Beer
{
    internal class CompareBeer : IComparer<Beer>
    {
        public CompareBeer()
        {
        }

        public int Compare(Beer be1, Beer be2)
        {
            return be1.Navn.CompareTo(be2.Navn);
        }
    }

}