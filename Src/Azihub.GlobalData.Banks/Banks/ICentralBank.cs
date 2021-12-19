namespace Azihub.GlobalData.Banking.Banks
{
    public interface ICentralBank
    {
        string Name { get; set; }
        string RegionCode { get; set; }
        string Website { get; set; }
    }
}
