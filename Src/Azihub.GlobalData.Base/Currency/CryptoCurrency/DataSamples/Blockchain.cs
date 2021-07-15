using System.Collections.Generic;
using Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.Interfaces;

namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.DataSamples
{
    public partial class Blockchain : IBlockchain
    {
        private Blockchain(string code, string name, byte vDecimal) 
        {
            Code = code;
            Name = name;
            Decimal = vDecimal;
        }

        public static Blockchain FromString(string code)
        {
            return BlockchainDict[code];
        }


        private static IDictionary<string, Blockchain> BlockchainDict => GetBlockchains();

        public string Code { get; }
        public string Name { get; }
        public byte Decimal { get; }
    }
}
