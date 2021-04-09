using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Direte
{
    class Dir
    {
        public static int DesYun(int x, int y)
        {
            if (x == 0 && y == 0) return 0;
            else return 1;
        }

        public static int ConYun(int x, int y)
        {
            if (x == 1 && y == 1) return 1;
            else return 0;
        }

        public static int Neg(int x)
        {
            if (x == 0) return 1;
            else if (x == 1) return 0;
            else return x;
        }

        public static int ImpL(int x, int y)
        {
            if (x == 0 && y == 1) return 0;
            else return 1;
        }

        public static int ImpR(int x, int y)
        {
            if (x == 1 && y == 0) return 0;
            else return 1;
        }

        public static int Inver(int x, int y)
        {
            if (x == y) return 1;
            else return 0;
        }

        public static int ArrowP(int x, int y)
        {
            if (x == 0 && y == 0) return 1;
            else return 0;
        }

        public static int ShtrShef(int x, int y)
        {
            if (x == 1 && y == 1) return 0;
            else return 1;
        }

        public static int Modul(int x, int y)
        {
            if (x != y) return 1;
            else return 0;
        }

    }
}
