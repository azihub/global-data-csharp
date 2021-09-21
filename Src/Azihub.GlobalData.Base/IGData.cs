namespace Azihub.GlobalData.Base
{
    public interface IGData<TDataType>
    {
        TDataType Data { get; }
        /// <summary>
        /// Return object of Type from String
        /// </summary>
        /// <returns></returns>
        TDataType FromString(string code);
    }

    public interface GData
    {
        string Code { get; }
    }
}