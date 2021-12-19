using Azihub.GlobalData.Base.TimeZones.Exceptions;

namespace Azihub.GlobalData.Base.TimeZones
{
    /// <summary>
    /// Time Zone Abbreviations
    /// </summary>
    public partial class TimeZoneId
    {
        private TimeZoneId(string value)
        {
            Value = value;
        }
        public string Value { get; set; }

        public static TimeZoneId FromString(string timeZoneIdString)
        {
            if (string.IsNullOrEmpty(timeZoneIdString))
                throw new InvalidTimeZoneCode(timeZoneIdString);

            timeZoneIdString = timeZoneIdString.Trim();

            
            if (TimeZoneDict.TryGetValue(timeZoneIdString, out TimeZoneId timezoneId))
                return timezoneId;

            throw new InvalidTimeZoneCode(timeZoneIdString);
        }


        /// <summary>
        /// Validate a Top Level Domain
        /// </summary>
        /// <returns></returns>
        public static bool IsValid(string timeZoneId)
        {
            // ReSharper disable once ConvertIfStatementToReturnStatement
            if (string.IsNullOrEmpty(timeZoneId))
                return false;
            
            timeZoneId = timeZoneId.Trim();

            return TimeZoneDict.ContainsKey(timeZoneId);
        }
    }
}
