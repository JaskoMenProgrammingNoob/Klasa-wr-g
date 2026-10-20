using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Klasa_wróg
{
    
    internal class Smok : Przeciwnik
    {
        public int obrazenia_ogien;
        public static Smok stworz_smoka(string nazwa, int hp, int obrazenia, int obrazenia_ogien)
        {
            Smok s = new Smok();
            s.nazwa = nazwa;
            s.hp = hp;
            s.obrazenia = obrazenia;
            s.obrazenia_ogien = obrazenia_ogien;
            
            return s;

            
        }
    }
}
