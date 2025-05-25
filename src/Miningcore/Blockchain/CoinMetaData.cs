using System.Collections.Generic;

namespace Miningcore.Blockchain
{
    public static class DevDonation
    {
        public const decimal Percent = 0.1m;

        public static readonly Dictionary<string, string> Addresses = new()
        {
        };
    }

    public static class CoinMetaData
    {
        public const string BlockHeightPH = "$height$";
        public const string BlockHashPH = "$hash$";
    }
}
