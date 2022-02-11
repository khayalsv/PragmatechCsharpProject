using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Card
{
    class MainCard
    {
        public int ID { get; set; }
        public long MainCardNumber { get; set; }
        public int MainAmount { get; set; }
        public DateTime ExperitionTime { get; set; }
    
        public static int id;

        public MainCard()
        {
            ID = ++id;
        }


    }

    class VirtualCard
    {
        public int ID { get; set; }
        public long VirtualCardNumber { get; set; }
        public int VirtualAmount { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
      
        public static int id;

        public VirtualCard()
        {
            ID = ++id;
        }

       
    }


}
