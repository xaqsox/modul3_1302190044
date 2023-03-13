using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302190044
{
    public class PosisiKarakterGame
    {
        private posisistate posisi;
        enum posisistate
        {
            jongkok,
            tengkurap,
            berdiri,
            terbang
        }
        public PosisiKarakterGame()
        {
            posisi = posisistate.jongkok;
        }
        void TombolW() 
        {
            if (posisi == posisistate.jongkok)
            {
                Console.WriteLine("Tombol arah atas ditekamn");
                posisi = posisistate.jongkok;
            }
        }
        void TombolX()
        {
            if (posisi == posisistate.terbang)
            {
                Console.WriteLine("tau dah");
            } else
            {
                Console.WriteLine("karakter terbang");
                posisi = posisistate.terbang;
            }
        }
        void TombolS()
        {
            if (posisi == posisistate.berdiri)
            {
                Console.WriteLine("Tombol arah bawah ditekamn");
                posisi = posisistate.jongkok;
            }
        }
        public static void Main(string[] args)
        {
           PosisiKarakterGame psi = new PosisiKarakterGame();   
            psi.TombolW();
            psi.TombolX();
        }
    }
}
