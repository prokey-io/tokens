using System;
using System.Collections.Generic;
using System.Text;

namespace ProkeyCoinsInfoGrabber.Models
{
    /// <summary>
    /// Response of : https://api.coingecko.com/api/v3/coins/{id}?localization=false&tickers=false&market_data=false&community_data=true&developer_data=false&sparkline=false
    /// Response is at the bottom of page
    /// </summary>
    public class CoingeckoCoinApiResponse: CoinBaseInfo
    {
        public string asset_platform_id { get; set; }

        public TokenPlatforms platforms { get; set; }

        public CoinLinks links { get; set; }

    }
    
    public class CoinLinks
    {
        public string[] homepage { get; set; }

        public string[] blockchain_site { get; set; }

        public string[] official_forum_url { get; set; }

        public string[] chat_url { get; set; }

        public string[] announcement_url { get; set; }

        public string twitter_screen_name { get; set; }

        public string facebook_username { get; set; }

        public string subreddit_url { get; set; }
        
        public ReposUrl repos_url { get; set; }
        
        public string[] bitbucket { get; set; }
    
    }

    public class ReposUrl
    {
        public string[] github { get; set; }
    }

}