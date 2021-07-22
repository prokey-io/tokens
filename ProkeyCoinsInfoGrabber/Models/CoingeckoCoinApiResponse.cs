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
        //Inherited fields
        //"id": "legolas-exchange",
        //"symbol": "lgo",
        //"name": "LGO Token",

        //"asset_platform_id": "ethereum",
        public string asset_platform_id { get; set; }

        //"platforms": {
        //  "ethereum": "0x0a50c93c762fdd6e56d86215c24aaad43ab629aa"
        //},
        public TokenPlatforms platforms { get; set; }

        public CoinLinks links { get; set; }

    }
    /// <summary>
    ///     
    /// "links": {
    ///"homepage": [
    ///  "https://lgo.markets/",
    ///  "",
    ///  ""
    ///],
    ///"blockchain_site": [
    ///  "https://etherscan.io/token/0x0a50c93c762fdd6e56d86215c24aaad43ab629aa",
    ///  "https://ethplorer.io/address/0x0a50c93c762fdd6e56d86215c24aaad43ab629aa",
    ///  "",
    ///  "",
    ///  ""
    ///],
    ///"official_forum_url": [
    ///  "",
    ///  "",
    ///  ""
    ///],
    ///"chat_url": [
    ///  "",
    ///  "",
    ///  ""
    ///],
    ///"announcement_url": [
    ///  "https://www.linkedin.com/company/lgo-group",
    ///  "https://lgo.group/posts/"
    ///],
    ///"twitter_screen_name": "LGOGROUP_",
    ///"facebook_username": "legolas.exchange",
    ///"bitcointalk_thread_identifier": 2383397,
    ///"telegram_channel_identifier": "legolasannouncements",
    ///"subreddit_url": "https://www.reddit.com/r/LegolasExchange/",
    ///"repos_url": {
    ///  "github": [
    ///    "https://github.com/lgo-public"
    ///  ],
    ///  "bitbucket": []
    ///}
    ///}
    /// </summary>
    public class CoinLinks
    {

        //"homepage": [
        //  "https://lgo.markets/",
        //  "",
        //  ""
        //],
        public string[] homepage { get; set; }

        //"blockchain_site": [
        //  "https://etherscan.io/token/0x0a50c93c762fdd6e56d86215c24aaad43ab629aa",
        //  "https://ethplorer.io/address/0x0a50c93c762fdd6e56d86215c24aaad43ab629aa",
        //  "",
        //  "",
        //  ""
        //],
        public string[] blockchain_site { get; set; }

        //"official_forum_url": [
        //  "",
        //  "",
        //  ""
        //],
        public string[] official_forum_url { get; set; }

        //"chat_url": [
        //  "",
        //  "",
        //  ""
        //],
        public string[] chat_url { get; set; }

        //"announcement_url": [
        //  "https://www.linkedin.com/company/lgo-group",
        //  "https://lgo.group/posts/"
        //],
        public string[] announcement_url { get; set; }

        //"twitter_screen_name": "LGOGROUP_",
        public string twitter_screen_name { get; set; }

        //"facebook_username": "legolas.exchange",
        public string facebook_username { get; set; }

        //"bitcointalk_thread_identifier": 2383397,

        //"telegram_channel_identifier": "legolasannouncements",

        //"subreddit_url": "https://www.reddit.com/r/LegolasExchange/",
        public string subreddit_url { get; set; }
        
        //"repos_url": {
        //  "github": [
        //    "https://github.com/lgo-public"
        //  ],
        public ReposUrl repos_url { get; set; }
        
        //"bitbucket": []
        public string[] bitbucket { get; set; }
    
    }
    /// <summary>
    /// "repos_url": {
    ///  "github": [
    ///    "https://github.com/lgo-public"
    ///  ],
    /// </summary>
    public class ReposUrl
    {
        public string[] github { get; set; }
    }

}
/*
 {
  "id": "legolas-exchange",
  "symbol": "lgo",
  "name": "LGO Token",
  "asset_platform_id": "ethereum",
  "platforms": {
    "ethereum": "0x0a50c93c762fdd6e56d86215c24aaad43ab629aa"
  },
  "block_time_in_minutes": 0,
  "hashing_algorithm": null,
  "categories": [
    "Centralized Exchange Token (CEX)",
    "Exchange-based Tokens"
  ],
  "public_notice": "Previously known LGO Exchange",
  "additional_notices": [],
  "description": {
    "en": "Legolas creates a new decentralized blockchain protocol that guarantees full transparency and prevents front-running and market manipulation. Legolas combines features of both centralized and decentralized architectures in order to exploit the best of both worlds: fiat support, strong authentication, simplicity, as well as transparency and fairness. Our extensive experience designing reliably secure systems and our strategic partnership with Ledger ensure state of the art safeguards for crypto assets. \r\n"
  },
  "links": {
    "homepage": [
      "https://lgo.markets/",
      "",
      ""
    ],
    "blockchain_site": [
      "https://etherscan.io/token/0x0a50c93c762fdd6e56d86215c24aaad43ab629aa",
      "https://ethplorer.io/address/0x0a50c93c762fdd6e56d86215c24aaad43ab629aa",
      "",
      "",
      ""
    ],
    "official_forum_url": [
      "",
      "",
      ""
    ],
    "chat_url": [
      "",
      "",
      ""
    ],
    "announcement_url": [
      "https://www.linkedin.com/company/lgo-group",
      "https://lgo.group/posts/"
    ],
    "twitter_screen_name": "LGOGROUP_",
    "facebook_username": "legolas.exchange",
    "bitcointalk_thread_identifier": 2383397,
    "telegram_channel_identifier": "legolasannouncements",
    "subreddit_url": "https://www.reddit.com/r/LegolasExchange/",
    "repos_url": {
      "github": [
        "https://github.com/lgo-public"
      ],
      "bitbucket": []
    }
  },
  "image": {
    "thumb": "https://assets.coingecko.com/coins/images/2353/thumb/2_JNnfVRPMBuA1hwnRubH72A.png?1595311622",
    "small": "https://assets.coingecko.com/coins/images/2353/small/2_JNnfVRPMBuA1hwnRubH72A.png?1595311622",
    "large": "https://assets.coingecko.com/coins/images/2353/large/2_JNnfVRPMBuA1hwnRubH72A.png?1595311622"
  },
  "country_origin": "FR",
  "genesis_date": "2018-03-03",
  "contract_address": "0x0a50c93c762fdd6e56d86215c24aaad43ab629aa",
  "sentiment_votes_up_percentage": null,
  "sentiment_votes_down_percentage": null,
  "ico_data": {
    "ico_start_date": "2018-02-01T00:00:00.000Z",
    "ico_end_date": "2018-02-15T00:00:00.000Z",
    "short_desc": "Fair and secure by design",
    "description": null,
    "links": {},
    "softcap_currency": "",
    "hardcap_currency": "BTC",
    "total_raised_currency": "USD",
    "softcap_amount": null,
    "hardcap_amount": "1000.0",
    "total_raised": "32133572.0",
    "quote_pre_sale_currency": "",
    "base_pre_sale_amount": null,
    "quote_pre_sale_amount": null,
    "quote_public_sale_currency": "BTC",
    "base_public_sale_amount": 1,
    "quote_public_sale_amount": 0.000035,
    "accepting_currencies": "",
    "country_origin": "FR",
    "pre_sale_start_date": null,
    "pre_sale_end_date": null,
    "whitelist_url": "",
    "whitelist_start_date": null,
    "whitelist_end_date": null,
    "bounty_detail_url": "",
    "amount_for_sale": null,
    "kyc_required": true,
    "whitelist_available": null,
    "pre_sale_available": null,
    "pre_sale_ended": false
  },
  "market_cap_rank": 422,
  "coingecko_rank": 997,
  "coingecko_score": 21.438,
  "developer_score": 0,
  "community_score": 28.523,
  "liquidity_score": 11.068,
  "public_interest_score": 0,
  "community_data": {
    "facebook_likes": null,
    "twitter_followers": 9318,
    "reddit_average_posts_48h": 0,
    "reddit_average_comments_48h": 0,
    "reddit_subscribers": 831,
    "reddit_accounts_active_48h": 10,
    "telegram_channel_user_count": 1488
  },
  "public_interest_stats": {
    "alexa_rank": 0,
    "bing_matches": null
  },
  "status_updates": [],
  "last_updated": "2021-07-21T17:38:00.245Z"
}
 */