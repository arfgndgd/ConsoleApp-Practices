using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    class Sales
    {
        public int ID { get; set; }
        public int GameID { get; set; }
        public int GamerID { get; set; }
        public int CampaignID { get; set; }
        public DateTime OrderDate { get; set; }
        public double Discount { get; set; }
    }
}
