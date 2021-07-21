
namespace ProkeyCoinsInfoGrabber.Models
{
    class EthplorerGetTokenInfoApiResponse: CoinBaseInfo
    {
        //name and symbol would be inherited
        //name: "Everex",
        //symbol: "EVX",

        //address: "0xf3db5fa2c66b7af3eb0c0b782510816cbe4813b8",
        public string address { get; set; }

        //decimals: "4",
        public string decimals { get; set; }

        //website: "https://lgo.markets/",
        public string website { get; set; }

        //image: "/images/LGO0a50c93c.png",
        public string image { get; set; }

        //facebook: "legolas.exchange",
        public string facebook { get; set; }

        //telegram: "https://t.me/legolasannouncements",
        public string telegram { get; set; }

        //twitter: "LGOGROUP_",
        public string twitter { get; set; }


        //reddit: "LegolasExchange",
        public string reddit { get; set; }


    }
}

/*
 address: "0x0a50c93c762fdd6e56d86215c24aaad43ab629aa",
name: "LGO Token",
decimals: "8",
symbol: "LGO",
totalSupply: "21695746384772916",
owner: "",
transfersCount: 56490,
lastUpdated: 1626856820,
issuancesCount: 0,
holdersCount: 7682,
image: "/images/LGO0a50c93c.png",
website: "https://lgo.markets/",
facebook: "legolas.exchange",
telegram: "https://t.me/legolasannouncements",
twitter: "LGOGROUP_",
reddit: "LegolasExchange",
coingecko: "legolas-exchange",
ethTransfersCount: 0,
price: {
rate: 0.24656844684844,
diff: 11.78,
diff7d: -13.18,
ts: 1626860970,
marketCapUsd: 13311131.982916566,
availableSupply: 53985545,
volume24h: 99866.64771478,
diff30d: -7.961635984150789,
volDiff1: -23.550156453945547,
volDiff7: 130.27888059730196,
volDiff30: -23.613517330187477,
currency: "USD"
},
publicTags: [
"Exchange Token",
"CEX"
],
countOps: 56490
}
 */