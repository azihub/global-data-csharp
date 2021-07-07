using PhoneNumbers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azihub.GlobalData.Validators
{
    public static class MobileNumber
    {
        /// <summary>
        /// Validate a mobile number from ulong source and ensure it is either MOBILE or FIXED_LINE_OR_MOBILE
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public static bool IsValidMobileNumber(ulong mobile)
        {
            PhoneNumberUtil phoneNumberUtil = PhoneNumberUtil.GetInstance();
            string e164PhoneNumber = $"+{mobile}";
            PhoneNumber phoneNumber;
            try
            {
                phoneNumber = phoneNumberUtil.Parse(e164PhoneNumber, null);
            }
            catch
            {
                return false;
            }

            PhoneNumberType type = phoneNumberUtil.GetNumberType(phoneNumber);
            if (type != PhoneNumberType.MOBILE && type != PhoneNumberType.FIXED_LINE_OR_MOBILE)
                return false;

            return true;
        }
    }
}
