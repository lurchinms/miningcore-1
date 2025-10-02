using System;
using System.Text;
using Miningcore.Crypto;
using Miningcore.Extensions;

namespace Miningcore.Blockchain.Satoshicash;

public static class SatoshicashUtils
{
    public static string GenerateEpochSeedHash(int epochDuration, uint unixTimeStamp, IHashAlgorithm headerHasher)
    {
        long epoch = (long) Math.Floor((decimal) unixTimeStamp / epochDuration);

        byte[] seedBytes = Encoding.UTF8.GetBytes(SatoshicashConstants.CoinbaseSeedHash.Replace(SatoshicashConstants.DataLabel, epoch.ToString()));

        byte[] seedHashBytes = new byte[32];
        headerHasher.Digest(seedBytes, seedHashBytes);

        return seedHashBytes.ToHexString();
    }
}
