using Azihub.GlobalData.Base.Timezones.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azihub.GlobalData.Base.TimeZones
{
    public partial class IanaCode
    {
        private IanaCode(string value)
        {
            Value = value;
        }
        public string Value { get; set; }

        public static IanaCode FromString(string ianaCodeString)
        {
            if (string.IsNullOrEmpty(ianaCodeString))
                throw new InvalidTimeZoneCode(ianaCodeString);

            ianaCodeString = ianaCodeString.Trim().ToUpper();

            
            if (IanaDict.TryGetValue(ianaCodeString, out IanaCode ianaCode))
                return ianaCode;

            throw new InvalidTimeZoneCode(ianaCodeString);
        }


        /// <summary>
        /// Validate a Top Level Domain
        /// </summary>
        /// <returns></returns>
        public static bool IsValid(string ianaCode)
        {
            // ReSharper disable once ConvertIfStatementToReturnStatement
            if (string.IsNullOrEmpty(ianaCode))
                return false;
            
            ianaCode = ianaCode.Trim();

            return IanaDict.ContainsKey(ianaCode);
        }
    }
}
