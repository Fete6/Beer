using System;
using System.Collections.Generic;

namespace Opgave_Beer
{
    internal class CompareBeerByProcent : IComparer<Beer>
    {
        public CompareBeerByProcent()
        {
        }

        public int Compare(Beer pro1, Beer pro2)
        {
            return pro1.Procent.CompareTo(pro2.Procent);
        }
    }
}