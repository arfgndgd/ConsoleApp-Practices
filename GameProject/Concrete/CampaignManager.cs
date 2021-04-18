using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaingService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "campaign added");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "campaign deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "campaign updated");
        }
    }
}
