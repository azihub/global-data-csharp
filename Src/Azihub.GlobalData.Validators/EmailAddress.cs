using Azihub.GlobalData.Base.TopLevelDomain;
using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Azihub.GlobalData.Validators
{
    public static class EmailAddress
    {
        public static bool IsValidEmailAddress(string address)
        {
            MailAddress mailAddress = GetEmailAddress(address);

            try
            {
                string tld = Regex.Match(mailAddress.Address, @"\.(?<tld>[a-z]{2,})$", RegexOptions.IgnoreCase).Groups["tld"].Value;
                if (Tld.IsValid(tld))
                    return true;
            }
            catch
            {
                return false;
            }

            return false;
        }

        public static MailAddress GetEmailAddress(string address)
        {
            if (String.IsNullOrEmpty(address.Trim()))
                throw new ArgumentNullException("Address is null");

            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException($"Invalid address: {address}");

            address = address.Trim();
            return new MailAddress(address);
        }
    }
}
