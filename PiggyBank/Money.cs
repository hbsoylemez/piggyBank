using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class Money
    {
        public decimal toplamMiktar = 0;
        public static List<decimal> BozukParaMiktarlari = new List<decimal> { 0.1m, 0.25m, 0.5m, 1m };
        public static List<decimal> KagıtParaMiktarlari = new List<decimal> { 5m, 10m, 20m, 50m, 100m, 200m };
    }
}
