
namespace ProkeyCoinsInfoGrabber.Models
{
    class EthplorerGetTokenInfoApiResponse: CoinBaseInfo
    {
        public string address { get; set; }

        public string decimals { get; set; }

        public string website { get; set; }

        public string image { get; set; }

        public string facebook { get; set; }

        public string telegram { get; set; }

        public string twitter { get; set; }

        public string reddit { get; set; }


    }
}