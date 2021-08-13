
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProkeyCoinsInfoGrabber.Models
{
    class ERC20Token
    {
        [JsonIgnore]
        public string id { get; set; }
        public string symbol { get; set; } = string.Empty;

        public string address { get; set; } = string.Empty;

        public int decimals { get; set; }

        public string name { get; set; } = string.Empty;

        public string ens_address { get; set; } = string.Empty;

        public string website { get; set; } = string.Empty;

        public ERC20TokenLogo logo { get; set; } = new ERC20TokenLogo();

        public ERC20TokenSupport support { get; set; } = new ERC20TokenSupport();

        public ERC20TokenSocial social { get; set; } = new ERC20TokenSocial();

        public void Map(EthplorerGetTokenInfoApiResponse tokenInfo)
        {
            decimals = int.Parse(tokenInfo.decimals);

            //Coingecko is prefered than website
            // HardRead 
            //website = (string.IsNullOrEmpty(website))? tokenInfo.website ?? string.Empty : website;
            if (string.IsNullOrEmpty(website)) 
                website = tokenInfo.website ?? string.Empty;
            //Coingecko is prefered than ethplorer for image
            if (string.IsNullOrEmpty(logo.src))
                logo.src = (!string.IsNullOrEmpty(tokenInfo.image))?"https://ethplorer.io" + tokenInfo.image: string.Empty;

            //Coingecko is prefered than facebook
            if(string.IsNullOrEmpty(social?.facebook))
                social.facebook = tokenInfo.facebook ?? string.Empty;

            //Coingecko is prefered than reddit
            if(string.IsNullOrEmpty(social?.reddit))
                social.reddit = tokenInfo.reddit ?? string.Empty;

            //Coingecko is prefered than ethplorer for twitter
            if(string.IsNullOrEmpty(social?.twitter))
                social.twitter = tokenInfo.twitter ?? string.Empty;

            social.telegram = tokenInfo.telegram ?? string.Empty;
            
        }

        internal void Map(CoingeckoCoinApiResponse coinInfo)
        {
            //if (coinInfo.links.chat_url != null && coinInfo.links.chat_url.Length > 0)
            //{
            //    if (!string.IsNullOrEmpty(coinInfo.links.chat_url[0]))
            //    {
            //        social.chat = coinInfo.links.chat_url[0];
            //    }

            //}
            social.chat = (coinInfo?.links?.chat_url?.Length > 0 ) ? coinInfo?.links?.chat_url[0] : string.Empty;

            //if (coinInfo.links.repos_url != null)
            //{
            //    if (coinInfo.links.repos_url.github != null && coinInfo.links.repos_url.github.Length>0)
            //    {
            //        social.github = coinInfo.links.repos_url.github[0];
            //    }
            //}
            social.github = (coinInfo?.links?.repos_url?.github?.Length>0) ? coinInfo?.links?.repos_url?.github?[0] : string.Empty;

            website = (coinInfo?.links?.homepage?.Length > 0) ? coinInfo?.links?.homepage?[0] : string.Empty;
            social.facebook = coinInfo?.links?.facebook_username ?? string.Empty;
            social.reddit = coinInfo?.links?.subreddit_url ?? string.Empty;
            social.twitter = coinInfo?.links?.twitter_screen_name ?? string.Empty;
        }
    }
    class ERC20TokenLogo
    {
        public string src { get; set; } = string.Empty;
        public string width { get; set; } = string.Empty;
        public string height { get; set; } = string.Empty;
        public string ipfs_hash { get; set; } = string.Empty;        
    }
    class ERC20TokenSupport
    {
        [EmailAddress]
        public string email { get; set; } = string.Empty;
        public string url { get; set; } = string.Empty;
    }
    
    class ERC20TokenSocial
    {
        public string blog { get; set; } = string.Empty;

        public string chat { get; set; } = string.Empty;

        public string discord { get; set; } = string.Empty;

        public string facebook { get; set; } = string.Empty;

        public string forum { get; set; } = string.Empty;

        public string github { get; set; } = string.Empty;

        public string gitter { get; set; } = string.Empty;

        public string instagram { get; set; } = string.Empty;

        public string linkedin { get; set; } = string.Empty;

        public string reddit { get; set; } = string.Empty;

        public string slack { get; set; } = string.Empty;

        public string telegram { get; set; } = string.Empty;

        public string twitter { get; set; } = string.Empty;

        public string youtube { get; set; } = string.Empty;

    }
}