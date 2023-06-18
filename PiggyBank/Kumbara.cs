using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class Kumbara
    {
        public double kumbaraToplamHacmi = 30; //cm küp
        public double kullanilanHacim ;
        double radius;
        double pi = 3.14;
        double height;

        double en;
        double boy;
        double kalinlik;
        public double hacimHesaplaBozukPara()
        {
            radius = 1;
            height = 1.65;
            double hacim = (pi * radius * radius * height) / 1000; //mm küp -> cm küp
            return hacim;
        }

        public double hacimHesaplaKagitPara()
        {
            en = 40; //  en / 4 -> 160 / 4 -> 40
            boy = 70;
            kalinlik = 2;
            double hacim = (en * boy * kalinlik) / 1000;
            return hacim;
        }
    }
}
