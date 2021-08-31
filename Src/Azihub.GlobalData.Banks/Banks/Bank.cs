using Azihub.GlobalData.Base.Country;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azihub.GlobalData.Banking.Banks
{
    public class Bank
    {
        public string NameDba { get; set; }
        public string Slug { get; set; }
        public string CorporateName { get; set; }
        
        /// <summary>
        /// Currently there are few banks who offer API, such as Bunq, Azlo, N26
        /// </summary>
        public bool BankSupportAPI { get; set; }

        public CountryIso2Code CountryISO2 { get; set; }
        public Uri WebsiteUrl { get; set; }

        /// <summary>
        /// It defines if the bank has different number of parameters to login into
        /// business or private account.
        /// For example CIMB Bank of Malaysia ask user to login at
        /// cimbclicks.com.my with a username and password without any OTP
        /// but for Business account, they would login at cimb.bizchannel.com.my
        /// with a DeviceOTP or TextOTP and Username, Password and OrganizationID.
        /// </summary>
        public bool UniformLogin { get; set; }

        /// <summary>
        /// ForceLogout is used for certain banks (CIMB for example) that have limitations with 
        /// concurrent login and bad logout process. this means webDriver must click LogOut button
        /// once done doing work.
        /// </summary>
        public bool ForceLogout { get; set; }

        public string PersonalBankingTitle { get; set; }
        public Uri PersonalBankingUrl { get; set; }
        public string BusinessBankingTitle { get; set; }
        public Uri BusinessBankingUrl { get; set; }
        public string BankLogoUrl { get; set; }
        public ushort? TimeZoneId { get; set; }
        /// <summary>
        /// Number of seconds from timezone to put into account.
        /// certain banks would only allow us download statement for yesterday 30 minutes
        /// or 60 minutes after midnight, ING or Rabobank
        /// </summary>
        public uint? TimeZoneGapStatementAdjustment { get; set; }
        public uint MaxDayReportStatement { get; set; }
        public bool? PersonalSupportPdf { get; set; } = true;
        public bool? PersonalSupportCsv { get; set; } = true;
        public bool? PersonalSupportXls { get; set; } = false;
        public bool? PersonalSupportXlsx { get; set; } = false;
        public bool? PersonalSupportMt940 { get; set; } = false;
        public bool? PersonalSupportMt942 { get; set; } = false;
        public bool? PersonalSupportCam52 { get; set; } = false;
        public bool? PersonalSupportCam53 { get; set; } = false;
        public bool? BusinessSupportPdf { get; set; } = true;
        public bool? BusinessSupportCsv { get; set; } = true;
        public bool? BusinessSupportXls { get; set; } = false;
        public bool? BusinessSupportXlsx { get; set; } = false;
        public bool? BusinessSupportMt940 { get; set; } = false;
        public bool? BusinessSupportMt942 { get; set; } = false;
        public bool? BusinessSupportCam52 { get; set; } = false;
        public bool? BusinessSupportCam53 { get; set; } = false;
        public string AccountNumberRegex { get; set; }
        public string AccountNumberPlaceholder { get; set; }
        public int AccountNumberLength { get; set; }
        public bool IbanSupport { get; set; }
        public string IbanRegex { get; set; }
        public string IbanPlaceholder { get; set; }
        public int? IbanLength { get; set; }
        public bool StatementSupportTimestamp { get; set; }
    }
}
