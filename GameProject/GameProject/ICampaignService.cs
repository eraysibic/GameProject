using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        void AddCampaign(Game gameName, Game price);
        void DeleteCampaign(Game gameName, Game price);
        void UpdateCampaign(Game gameName, Game price);
    }
}
