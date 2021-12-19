namespace Azihub.GlobalData.Banking.Banks
{
    public class CentralBankUnion : ICentralBank
    {
        public string Name { get; set; }
        public string RegionCode { get; set; }
        public string Website { get; set; }
    }
}
