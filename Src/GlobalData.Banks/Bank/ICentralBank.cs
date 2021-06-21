namespace GlobalData.Base.Bank
{
    public interface ICentralBank
    {
        public string Name { get; set; }
        public string RegionCode { get; set; }
        public string Website { get; set; }
    }

    public class CentralBankUnion : ICentralBank
    {
        public string Name { get; set; }
        public string RegionCode { get; set; }
        public string Website { get; set; }
    }
}
