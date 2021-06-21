using System.Collections.Generic;
using System.Runtime.Serialization;
using Azihub.GlobalData.Base.Country.Exceptions;

namespace Azihub.GlobalData.Base.Country
{
    [DataContract]

    public class CountryIso2Code
    {
        public CountryIso2Code()
        {

        }
        public CountryIso2Code(string code)
        {
            Code = code;
        }

        [DataMember(Order = 6)]

        public string Code { get; }

        public override string ToString()
        {
            return Code;
        }

        #region Dictionary
        public static Dictionary<string, CountryIso2Code> Codes { get; } = new()
        {
            {Iso2Codes.AB, new CountryIso2Code(Iso2Codes.AB)},
            {Iso2Codes.AC, new CountryIso2Code(Iso2Codes.AC)},
            {Iso2Codes.AD, new CountryIso2Code(Iso2Codes.AD)},
            {Iso2Codes.AE, new CountryIso2Code(Iso2Codes.AE)},
            {Iso2Codes.AF, new CountryIso2Code(Iso2Codes.AF)},
            {Iso2Codes.AG, new CountryIso2Code(Iso2Codes.AG)},
            {Iso2Codes.AI, new CountryIso2Code(Iso2Codes.AI)},
            {Iso2Codes.AL, new CountryIso2Code(Iso2Codes.AL)},
            {Iso2Codes.AM, new CountryIso2Code(Iso2Codes.AM)},
            {Iso2Codes.AN, new CountryIso2Code(Iso2Codes.AN)},
            {Iso2Codes.AO, new CountryIso2Code(Iso2Codes.AO)},
            {Iso2Codes.AQ, new CountryIso2Code(Iso2Codes.AQ)},
            {Iso2Codes.AR, new CountryIso2Code(Iso2Codes.AR)},
            {Iso2Codes.AS, new CountryIso2Code(Iso2Codes.AS)},
            {Iso2Codes.AT, new CountryIso2Code(Iso2Codes.AT)},
            {Iso2Codes.AU, new CountryIso2Code(Iso2Codes.AU)},
            {Iso2Codes.AW, new CountryIso2Code(Iso2Codes.AW)},
            {Iso2Codes.AX, new CountryIso2Code(Iso2Codes.AX)},
            {Iso2Codes.AZ, new CountryIso2Code(Iso2Codes.AZ)},
            {Iso2Codes.BA, new CountryIso2Code(Iso2Codes.BA)},
            {Iso2Codes.BB, new CountryIso2Code(Iso2Codes.BB)},
            {Iso2Codes.BD, new CountryIso2Code(Iso2Codes.BD)},
            {Iso2Codes.BE, new CountryIso2Code(Iso2Codes.BE)},
            {Iso2Codes.BF, new CountryIso2Code(Iso2Codes.BF)},
            {Iso2Codes.BG, new CountryIso2Code(Iso2Codes.BG)},
            {Iso2Codes.BH, new CountryIso2Code(Iso2Codes.BH)},
            {Iso2Codes.BI, new CountryIso2Code(Iso2Codes.BI)},
            {Iso2Codes.BJ, new CountryIso2Code(Iso2Codes.BJ)},
            {Iso2Codes.BM, new CountryIso2Code(Iso2Codes.BM)},
            {Iso2Codes.BN, new CountryIso2Code(Iso2Codes.BN)},
            {Iso2Codes.BO, new CountryIso2Code(Iso2Codes.BO)},
            {Iso2Codes.BR, new CountryIso2Code(Iso2Codes.BR)},
            {Iso2Codes.BS, new CountryIso2Code(Iso2Codes.BS)},
            {Iso2Codes.BT, new CountryIso2Code(Iso2Codes.BT)},
            {Iso2Codes.BW, new CountryIso2Code(Iso2Codes.BW)},
            {Iso2Codes.BY, new CountryIso2Code(Iso2Codes.BY)},
            {Iso2Codes.BZ, new CountryIso2Code(Iso2Codes.BZ)},
            {Iso2Codes.CA, new CountryIso2Code(Iso2Codes.CA)},
            {Iso2Codes.CC, new CountryIso2Code(Iso2Codes.CC)},
            {Iso2Codes.CD, new CountryIso2Code(Iso2Codes.CD)},
            {Iso2Codes.CF, new CountryIso2Code(Iso2Codes.CF)},
            {Iso2Codes.CG, new CountryIso2Code(Iso2Codes.CG)},
            {Iso2Codes.CH, new CountryIso2Code(Iso2Codes.CH)},
            {Iso2Codes.CI, new CountryIso2Code(Iso2Codes.CI)},
            {Iso2Codes.CK, new CountryIso2Code(Iso2Codes.CK)},
            {Iso2Codes.CL, new CountryIso2Code(Iso2Codes.CL)},
            {Iso2Codes.CM, new CountryIso2Code(Iso2Codes.CM)},
            {Iso2Codes.CN, new CountryIso2Code(Iso2Codes.CN)},
            {Iso2Codes.CO, new CountryIso2Code(Iso2Codes.CO)},
            {Iso2Codes.CR, new CountryIso2Code(Iso2Codes.CR)},
            {Iso2Codes.CU, new CountryIso2Code(Iso2Codes.CU)},
            {Iso2Codes.CV, new CountryIso2Code(Iso2Codes.CV)},
            {Iso2Codes.CX, new CountryIso2Code(Iso2Codes.CX)},
            {Iso2Codes.CY, new CountryIso2Code(Iso2Codes.CY)},
            {Iso2Codes.CZ, new CountryIso2Code(Iso2Codes.CZ)},
            {Iso2Codes.DE, new CountryIso2Code(Iso2Codes.DE)},
            {Iso2Codes.DJ, new CountryIso2Code(Iso2Codes.DJ)},
            {Iso2Codes.DK, new CountryIso2Code(Iso2Codes.DK)},
            {Iso2Codes.DM, new CountryIso2Code(Iso2Codes.DM)},
            {Iso2Codes.DO, new CountryIso2Code(Iso2Codes.DO)},
            {Iso2Codes.DZ, new CountryIso2Code(Iso2Codes.DZ)},
            {Iso2Codes.EC, new CountryIso2Code(Iso2Codes.EC)},
            {Iso2Codes.EE, new CountryIso2Code(Iso2Codes.EE)},
            {Iso2Codes.EG, new CountryIso2Code(Iso2Codes.EG)},
            {Iso2Codes.EH, new CountryIso2Code(Iso2Codes.EH)},
            {Iso2Codes.ER, new CountryIso2Code(Iso2Codes.ER)},
            {Iso2Codes.ES, new CountryIso2Code(Iso2Codes.ES)},
            {Iso2Codes.ET, new CountryIso2Code(Iso2Codes.ET)},
            {Iso2Codes.FI, new CountryIso2Code(Iso2Codes.FI)},
            {Iso2Codes.FJ, new CountryIso2Code(Iso2Codes.FJ)},
            {Iso2Codes.FK, new CountryIso2Code(Iso2Codes.FK)},
            {Iso2Codes.FM, new CountryIso2Code(Iso2Codes.FM)},
            {Iso2Codes.FO, new CountryIso2Code(Iso2Codes.FO)},
            {Iso2Codes.FR, new CountryIso2Code(Iso2Codes.FR)},
            {Iso2Codes.GA, new CountryIso2Code(Iso2Codes.GA)},
            {Iso2Codes.GB, new CountryIso2Code(Iso2Codes.GB)},
            {Iso2Codes.GD, new CountryIso2Code(Iso2Codes.GD)},
            {Iso2Codes.GE, new CountryIso2Code(Iso2Codes.GE)},
            {Iso2Codes.GF, new CountryIso2Code(Iso2Codes.GF)},
            {Iso2Codes.GG, new CountryIso2Code(Iso2Codes.GG)},
            {Iso2Codes.GH, new CountryIso2Code(Iso2Codes.GH)},
            {Iso2Codes.GI, new CountryIso2Code(Iso2Codes.GI)},
            {Iso2Codes.GL, new CountryIso2Code(Iso2Codes.GL)},
            {Iso2Codes.GM, new CountryIso2Code(Iso2Codes.GM)},
            {Iso2Codes.GN, new CountryIso2Code(Iso2Codes.GN)},
            {Iso2Codes.GO, new CountryIso2Code(Iso2Codes.GO)},
            {Iso2Codes.GP, new CountryIso2Code(Iso2Codes.GP)},
            {Iso2Codes.GQ, new CountryIso2Code(Iso2Codes.GQ)},
            {Iso2Codes.GR, new CountryIso2Code(Iso2Codes.GR)},
            {Iso2Codes.GS, new CountryIso2Code(Iso2Codes.GS)},
            {Iso2Codes.GT, new CountryIso2Code(Iso2Codes.GT)},
            {Iso2Codes.GU, new CountryIso2Code(Iso2Codes.GU)},
            {Iso2Codes.GW, new CountryIso2Code(Iso2Codes.GW)},
            {Iso2Codes.GY, new CountryIso2Code(Iso2Codes.GY)},
            {Iso2Codes.HK, new CountryIso2Code(Iso2Codes.HK)},
            {Iso2Codes.HN, new CountryIso2Code(Iso2Codes.HN)},
            {Iso2Codes.HR, new CountryIso2Code(Iso2Codes.HR)},
            {Iso2Codes.HT, new CountryIso2Code(Iso2Codes.HT)},
            {Iso2Codes.HU, new CountryIso2Code(Iso2Codes.HU)},
            {Iso2Codes.ID, new CountryIso2Code(Iso2Codes.ID)},
            {Iso2Codes.IE, new CountryIso2Code(Iso2Codes.IE)},
            {Iso2Codes.IL, new CountryIso2Code(Iso2Codes.IL)},
            {Iso2Codes.IM, new CountryIso2Code(Iso2Codes.IM)},
            {Iso2Codes.IN, new CountryIso2Code(Iso2Codes.IN)},
            {Iso2Codes.IO, new CountryIso2Code(Iso2Codes.IO)},
            {Iso2Codes.IQ, new CountryIso2Code(Iso2Codes.IQ)},
            {Iso2Codes.IR, new CountryIso2Code(Iso2Codes.IR)},
            {Iso2Codes.IS, new CountryIso2Code(Iso2Codes.IS)},
            {Iso2Codes.IT, new CountryIso2Code(Iso2Codes.IT)},
            {Iso2Codes.JE, new CountryIso2Code(Iso2Codes.JE)},
            {Iso2Codes.JM, new CountryIso2Code(Iso2Codes.JM)},
            {Iso2Codes.JO, new CountryIso2Code(Iso2Codes.JO)},
            {Iso2Codes.JP, new CountryIso2Code(Iso2Codes.JP)},
            {Iso2Codes.KE, new CountryIso2Code(Iso2Codes.KE)},
            {Iso2Codes.KG, new CountryIso2Code(Iso2Codes.KG)},
            {Iso2Codes.KH, new CountryIso2Code(Iso2Codes.KH)},
            {Iso2Codes.KI, new CountryIso2Code(Iso2Codes.KI)},
            {Iso2Codes.KM, new CountryIso2Code(Iso2Codes.KM)},
            {Iso2Codes.KN, new CountryIso2Code(Iso2Codes.KN)},
            {Iso2Codes.KP, new CountryIso2Code(Iso2Codes.KP)},
            {Iso2Codes.KR, new CountryIso2Code(Iso2Codes.KR)},
            {Iso2Codes.KW, new CountryIso2Code(Iso2Codes.KW)},
            {Iso2Codes.KY, new CountryIso2Code(Iso2Codes.KY)},
            {Iso2Codes.KZ, new CountryIso2Code(Iso2Codes.KZ)},
            {Iso2Codes.LA, new CountryIso2Code(Iso2Codes.LA)},
            {Iso2Codes.LB, new CountryIso2Code(Iso2Codes.LB)},
            {Iso2Codes.LC, new CountryIso2Code(Iso2Codes.LC)},
            {Iso2Codes.LI, new CountryIso2Code(Iso2Codes.LI)},
            {Iso2Codes.LK, new CountryIso2Code(Iso2Codes.LK)},
            {Iso2Codes.LR, new CountryIso2Code(Iso2Codes.LR)},
            {Iso2Codes.LS, new CountryIso2Code(Iso2Codes.LS)},
            {Iso2Codes.LT, new CountryIso2Code(Iso2Codes.LT)},
            {Iso2Codes.LU, new CountryIso2Code(Iso2Codes.LU)},
            {Iso2Codes.LV, new CountryIso2Code(Iso2Codes.LV)},
            {Iso2Codes.LY, new CountryIso2Code(Iso2Codes.LY)},
            {Iso2Codes.MA, new CountryIso2Code(Iso2Codes.MA)},
            {Iso2Codes.MC, new CountryIso2Code(Iso2Codes.MC)},
            {Iso2Codes.MD, new CountryIso2Code(Iso2Codes.MD)},
            {Iso2Codes.ME, new CountryIso2Code(Iso2Codes.ME)},
            {Iso2Codes.MG, new CountryIso2Code(Iso2Codes.MG)},
            {Iso2Codes.MH, new CountryIso2Code(Iso2Codes.MH)},
            {Iso2Codes.MK, new CountryIso2Code(Iso2Codes.MK)},
            {Iso2Codes.ML, new CountryIso2Code(Iso2Codes.ML)},
            {Iso2Codes.MM, new CountryIso2Code(Iso2Codes.MM)},
            {Iso2Codes.MN, new CountryIso2Code(Iso2Codes.MN)},
            {Iso2Codes.MO, new CountryIso2Code(Iso2Codes.MO)},
            {Iso2Codes.MP, new CountryIso2Code(Iso2Codes.MP)},
            {Iso2Codes.MQ, new CountryIso2Code(Iso2Codes.MQ)},
            {Iso2Codes.MR, new CountryIso2Code(Iso2Codes.MR)},
            {Iso2Codes.MS, new CountryIso2Code(Iso2Codes.MS)},
            {Iso2Codes.MT, new CountryIso2Code(Iso2Codes.MT)},
            {Iso2Codes.MU, new CountryIso2Code(Iso2Codes.MU)},
            {Iso2Codes.MV, new CountryIso2Code(Iso2Codes.MV)},
            {Iso2Codes.MW, new CountryIso2Code(Iso2Codes.MW)},
            {Iso2Codes.MX, new CountryIso2Code(Iso2Codes.MX)},
            {Iso2Codes.MY, new CountryIso2Code(Iso2Codes.MY)},
            {Iso2Codes.MZ, new CountryIso2Code(Iso2Codes.MZ)},
            {Iso2Codes.NA, new CountryIso2Code(Iso2Codes.NA)},
            {Iso2Codes.NC, new CountryIso2Code(Iso2Codes.NC)},
            {Iso2Codes.NE, new CountryIso2Code(Iso2Codes.NE)},
            {Iso2Codes.NF, new CountryIso2Code(Iso2Codes.NF)},
            {Iso2Codes.NG, new CountryIso2Code(Iso2Codes.NG)},
            {Iso2Codes.NI, new CountryIso2Code(Iso2Codes.NI)},
            {Iso2Codes.NL, new CountryIso2Code(Iso2Codes.NL)},
            {Iso2Codes.NO, new CountryIso2Code(Iso2Codes.NO)},
            {Iso2Codes.NP, new CountryIso2Code(Iso2Codes.NP)},
            {Iso2Codes.NR, new CountryIso2Code(Iso2Codes.NR)},
            {Iso2Codes.NU, new CountryIso2Code(Iso2Codes.NU)},
            {Iso2Codes.NZ, new CountryIso2Code(Iso2Codes.NZ)},
            {Iso2Codes.OM, new CountryIso2Code(Iso2Codes.OM)},
            {Iso2Codes.PA, new CountryIso2Code(Iso2Codes.PA)},
            {Iso2Codes.PE, new CountryIso2Code(Iso2Codes.PE)},
            {Iso2Codes.PF, new CountryIso2Code(Iso2Codes.PF)},
            {Iso2Codes.PG, new CountryIso2Code(Iso2Codes.PG)},
            {Iso2Codes.PH, new CountryIso2Code(Iso2Codes.PH)},
            {Iso2Codes.PK, new CountryIso2Code(Iso2Codes.PK)},
            {Iso2Codes.PL, new CountryIso2Code(Iso2Codes.PL)},
            {Iso2Codes.PM, new CountryIso2Code(Iso2Codes.PM)},
            {Iso2Codes.PN, new CountryIso2Code(Iso2Codes.PN)},
            {Iso2Codes.PR, new CountryIso2Code(Iso2Codes.PR)},
            {Iso2Codes.PS, new CountryIso2Code(Iso2Codes.PS)},
            {Iso2Codes.PT, new CountryIso2Code(Iso2Codes.PT)},
            {Iso2Codes.PW, new CountryIso2Code(Iso2Codes.PW)},
            {Iso2Codes.PY, new CountryIso2Code(Iso2Codes.PY)},
            {Iso2Codes.QA, new CountryIso2Code(Iso2Codes.QA)},
            {Iso2Codes.RE, new CountryIso2Code(Iso2Codes.RE)},
            {Iso2Codes.RO, new CountryIso2Code(Iso2Codes.RO)},
            {Iso2Codes.RS, new CountryIso2Code(Iso2Codes.RS)},
            {Iso2Codes.RU, new CountryIso2Code(Iso2Codes.RU)},
            {Iso2Codes.RW, new CountryIso2Code(Iso2Codes.RW)},
            {Iso2Codes.SA, new CountryIso2Code(Iso2Codes.SA)},
            {Iso2Codes.SB, new CountryIso2Code(Iso2Codes.SB)},
            {Iso2Codes.SC, new CountryIso2Code(Iso2Codes.SC)},
            {Iso2Codes.SD, new CountryIso2Code(Iso2Codes.SD)},
            {Iso2Codes.SE, new CountryIso2Code(Iso2Codes.SE)},
            {Iso2Codes.SG, new CountryIso2Code(Iso2Codes.SG)},
            {Iso2Codes.SH, new CountryIso2Code(Iso2Codes.SH)},
            {Iso2Codes.SI, new CountryIso2Code(Iso2Codes.SI)},
            {Iso2Codes.SK, new CountryIso2Code(Iso2Codes.SK)},
            {Iso2Codes.SL, new CountryIso2Code(Iso2Codes.SL)},
            {Iso2Codes.SM, new CountryIso2Code(Iso2Codes.SM)},
            {Iso2Codes.SN, new CountryIso2Code(Iso2Codes.SN)},
            {Iso2Codes.SO, new CountryIso2Code(Iso2Codes.SO)},
            {Iso2Codes.SR, new CountryIso2Code(Iso2Codes.SR)},
            {Iso2Codes.SS, new CountryIso2Code(Iso2Codes.SS)},
            {Iso2Codes.ST, new CountryIso2Code(Iso2Codes.ST)},
            {Iso2Codes.SV, new CountryIso2Code(Iso2Codes.SV)},
            {Iso2Codes.SX, new CountryIso2Code(Iso2Codes.SX)},
            {Iso2Codes.SY, new CountryIso2Code(Iso2Codes.SY)},
            {Iso2Codes.SZ, new CountryIso2Code(Iso2Codes.SZ)},
            {Iso2Codes.TA, new CountryIso2Code(Iso2Codes.TA)},
            {Iso2Codes.TC, new CountryIso2Code(Iso2Codes.TC)},
            {Iso2Codes.TD, new CountryIso2Code(Iso2Codes.TD)},
            {Iso2Codes.TG, new CountryIso2Code(Iso2Codes.TG)},
            {Iso2Codes.TH, new CountryIso2Code(Iso2Codes.TH)},
            {Iso2Codes.TJ, new CountryIso2Code(Iso2Codes.TJ)},
            {Iso2Codes.TK, new CountryIso2Code(Iso2Codes.TK)},
            {Iso2Codes.TL, new CountryIso2Code(Iso2Codes.TL)},
            {Iso2Codes.TM, new CountryIso2Code(Iso2Codes.TM)},
            {Iso2Codes.TN, new CountryIso2Code(Iso2Codes.TN)},
            {Iso2Codes.TO, new CountryIso2Code(Iso2Codes.TO)},
            {Iso2Codes.TR, new CountryIso2Code(Iso2Codes.TR)},
            {Iso2Codes.TT, new CountryIso2Code(Iso2Codes.TT)},
            {Iso2Codes.TV, new CountryIso2Code(Iso2Codes.TV)},
            {Iso2Codes.TW, new CountryIso2Code(Iso2Codes.TW)},
            {Iso2Codes.TZ, new CountryIso2Code(Iso2Codes.TZ)},
            {Iso2Codes.UA, new CountryIso2Code(Iso2Codes.UA)},
            {Iso2Codes.UG, new CountryIso2Code(Iso2Codes.UG)},
            {Iso2Codes.US, new CountryIso2Code(Iso2Codes.US)},
            {Iso2Codes.UY, new CountryIso2Code(Iso2Codes.UY)},
            {Iso2Codes.UZ, new CountryIso2Code(Iso2Codes.UZ)},
            {Iso2Codes.VA, new CountryIso2Code(Iso2Codes.VA)},
            {Iso2Codes.VC, new CountryIso2Code(Iso2Codes.VC)},
            {Iso2Codes.VE, new CountryIso2Code(Iso2Codes.VE)},
            {Iso2Codes.VG, new CountryIso2Code(Iso2Codes.VG)},
            {Iso2Codes.VI, new CountryIso2Code(Iso2Codes.VI)},
            {Iso2Codes.VN, new CountryIso2Code(Iso2Codes.VN)},
            {Iso2Codes.VU, new CountryIso2Code(Iso2Codes.VU)},
            {Iso2Codes.WF, new CountryIso2Code(Iso2Codes.WF)},
            {Iso2Codes.WS, new CountryIso2Code(Iso2Codes.WS)},
            {Iso2Codes.XK, new CountryIso2Code(Iso2Codes.XK)},
            {Iso2Codes.XN, new CountryIso2Code(Iso2Codes.XN)},
            {Iso2Codes.YE, new CountryIso2Code(Iso2Codes.YE)},
            {Iso2Codes.YT, new CountryIso2Code(Iso2Codes.YT)},
            {Iso2Codes.ZA, new CountryIso2Code(Iso2Codes.ZA)},
            {Iso2Codes.ZM, new CountryIso2Code(Iso2Codes.ZM)},
            {Iso2Codes.ZW, new CountryIso2Code(Iso2Codes.ZW)},
        };
        #endregion

        /*
        */
        /// <summary>
        /// Create GdCountryCode from string value (case insensitive)
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static CountryIso2Code FromString(string code)
        {
            if (string.IsNullOrEmpty(code))
                throw new InvalidCountryCodeException(code);


            code = code.Trim().ToUpper();
            if (Codes.TryGetValue(code, out CountryIso2Code gdCountryCode))
                return gdCountryCode;

            throw new InvalidCountryCodeException(code);
        }

        #region Country Name
        /*
        SELECT CONCAT('/// <summary>', CHARACTER(13),
              '/// ',name,' (',country_code_iso2,')', CHARACTER(13),
              '/// </summary>', CHARACTER(13),
              'public static CountryIso2Code ', REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(name, ',', '') , ' ', '_') , '(', '') , ')', '') , '-', '_'), ' => new(Iso2Codes.',country_code_iso2,');', CHARACTER(13), CHARACTER(13))
        FROM `gd_countries`
        ORDER BY `country_code_iso2`			  		 
        */
        /// <summary>
        /// Abkhazia (AB)
        /// </summary>
        public static CountryIso2Code Abkhazia => new(Iso2Codes.AB);

        /// <summary>
        /// Ascension Island (AC)
        /// </summary>
        public static CountryIso2Code AscensionIsland => new(Iso2Codes.AC);

        /// <summary>
        /// Andorra (AD)
        /// </summary>
        public static CountryIso2Code Andorra => new(Iso2Codes.AD);

        /// <summary>
        /// United Arab Emirates (AE)
        /// </summary>
        public static CountryIso2Code UnitedArabEmirates => new(Iso2Codes.AE);

        /// <summary>
        /// Afghanistan (AF)
        /// </summary>
        public static CountryIso2Code Afghanistan => new(Iso2Codes.AF);

        /// <summary>
        /// Antigua And Barbuda (AG)
        /// </summary>
        public static CountryIso2Code AntiguaAndBarbuda => new(Iso2Codes.AG);

        /// <summary>
        /// Anguilla (AI)
        /// </summary>
        public static CountryIso2Code Anguilla => new(Iso2Codes.AI);

        /// <summary>
        /// Albania (AL)
        /// </summary>
        public static CountryIso2Code Albania => new(Iso2Codes.AL);

        /// <summary>
        /// Armenia (AM)
        /// </summary>
        public static CountryIso2Code Armenia => new(Iso2Codes.AM);

        /// <summary>
        /// Netherlands Antilles (AN)
        /// </summary>
        public static CountryIso2Code NetherlandsAntilles => new(Iso2Codes.AN);

        /// <summary>
        /// Angola (AO)
        /// </summary>
        public static CountryIso2Code Angola => new(Iso2Codes.AO);

        /// <summary>
        /// Antarctica (AQ)
        /// </summary>
        public static CountryIso2Code Antarctica => new(Iso2Codes.AQ);

        /// <summary>
        /// Argentina (AR)
        /// </summary>
        public static CountryIso2Code Argentina => new(Iso2Codes.AR);

        /// <summary>
        /// American Samoa (AS)
        /// </summary>
        public static CountryIso2Code AmericanSamoa => new(Iso2Codes.AS);

        /// <summary>
        /// Austria (AT)
        /// </summary>
        public static CountryIso2Code Austria => new(Iso2Codes.AT);

        /// <summary>
        /// Australia (AU)
        /// </summary>
        public static CountryIso2Code Australia => new(Iso2Codes.AU);

        /// <summary>
        /// Aruba (AW)
        /// </summary>
        public static CountryIso2Code Aruba => new(Iso2Codes.AW);

        /// <summary>
        /// Aland Islands (AX)
        /// </summary>
        public static CountryIso2Code AlandIslands => new(Iso2Codes.AX);

        /// <summary>
        /// Azerbaijan (AZ)
        /// </summary>
        public static CountryIso2Code Azerbaijan => new(Iso2Codes.AZ);

        /// <summary>
        /// Bosnia And Herzegovina (BA)
        /// </summary>
        public static CountryIso2Code BosniaAndHerzegovina => new(Iso2Codes.BA);

        /// <summary>
        /// Barbados (BB)
        /// </summary>
        public static CountryIso2Code Barbados => new(Iso2Codes.BB);

        /// <summary>
        /// Bangladesh (BD)
        /// </summary>
        public static CountryIso2Code Bangladesh => new(Iso2Codes.BD);

        /// <summary>
        /// Belgium (BE)
        /// </summary>
        public static CountryIso2Code Belgium => new(Iso2Codes.BE);

        /// <summary>
        /// Burkina Faso (BF)
        /// </summary>
        public static CountryIso2Code BurkinaFaso => new(Iso2Codes.BF);

        /// <summary>
        /// Bulgaria (BG)
        /// </summary>
        public static CountryIso2Code Bulgaria => new(Iso2Codes.BG);

        /// <summary>
        /// Bahrain (BH)
        /// </summary>
        public static CountryIso2Code Bahrain => new(Iso2Codes.BH);

        /// <summary>
        /// Burundi (BI)
        /// </summary>
        public static CountryIso2Code Burundi => new(Iso2Codes.BI);

        /// <summary>
        /// Benin (BJ)
        /// </summary>
        public static CountryIso2Code Benin => new(Iso2Codes.BJ);

        /// <summary>
        /// Bermuda (BM)
        /// </summary>
        public static CountryIso2Code Bermuda => new(Iso2Codes.BM);

        /// <summary>
        /// Brunei Darussalam (BN)
        /// </summary>
        public static CountryIso2Code BruneiDarussalam => new(Iso2Codes.BN);

        /// <summary>
        /// Bolivia (BO)
        /// </summary>
        public static CountryIso2Code Bolivia => new(Iso2Codes.BO);

        /// <summary>
        /// Brazil (BR)
        /// </summary>
        public static CountryIso2Code Brazil => new(Iso2Codes.BR);

        /// <summary>
        /// Bahamas (BS)
        /// </summary>
        public static CountryIso2Code Bahamas => new(Iso2Codes.BS);

        /// <summary>
        /// Bhutan (BT)
        /// </summary>
        public static CountryIso2Code Bhutan => new(Iso2Codes.BT);

        /// <summary>
        /// Botswana (BW)
        /// </summary>
        public static CountryIso2Code Botswana => new(Iso2Codes.BW);

        /// <summary>
        /// Belarus (BY)
        /// </summary>
        public static CountryIso2Code Belarus => new(Iso2Codes.BY);

        /// <summary>
        /// Belize (BZ)
        /// </summary>
        public static CountryIso2Code Belize => new(Iso2Codes.BZ);

        /// <summary>
        /// Canada (CA)
        /// </summary>
        public static CountryIso2Code Canada => new(Iso2Codes.CA);

        /// <summary>
        /// Cocos (Keeling) Islands (CC)
        /// </summary>
        public static CountryIso2Code CocosKeelingIslands => new(Iso2Codes.CC);

        /// <summary>
        /// Congo, Democratic Republic of the (CD)
        /// </summary>
        public static CountryIso2Code CongoDemocraticRepublicOfThe => new(Iso2Codes.CD);

        /// <summary>
        /// Central African Republic (CF)
        /// </summary>
        public static CountryIso2Code CentralAfricanRepublic => new(Iso2Codes.CF);

        /// <summary>
        /// Congo, Republic of the (CG)
        /// </summary>
        public static CountryIso2Code CongoRepublicOfThe => new(Iso2Codes.CG);

        /// <summary>
        /// Switzerland (CH)
        /// </summary>
        public static CountryIso2Code Switzerland => new(Iso2Codes.CH);

        /// <summary>
        /// Ivory Coast (CI)
        /// </summary>
        public static CountryIso2Code IvoryCoast => new(Iso2Codes.CI);

        /// <summary>
        /// Cook Islands (CK)
        /// </summary>
        public static CountryIso2Code CookIslands => new(Iso2Codes.CK);

        /// <summary>
        /// Chile (CL)
        /// </summary>
        public static CountryIso2Code Chile => new(Iso2Codes.CL);

        /// <summary>
        /// Cameroon (CM)
        /// </summary>
        public static CountryIso2Code Cameroon => new(Iso2Codes.CM);

        /// <summary>
        /// China (CN)
        /// </summary>
        public static CountryIso2Code China => new(Iso2Codes.CN);

        /// <summary>
        /// Colombia (CO)
        /// </summary>
        public static CountryIso2Code Colombia => new(Iso2Codes.CO);

        /// <summary>
        /// Costa Rica (CR)
        /// </summary>
        public static CountryIso2Code CostaRica => new(Iso2Codes.CR);

        /// <summary>
        /// Cuba (CU)
        /// </summary>
        public static CountryIso2Code Cuba => new(Iso2Codes.CU);

        /// <summary>
        /// Cape Verde (CV)
        /// </summary>
        public static CountryIso2Code CapeVerde => new(Iso2Codes.CV);

        /// <summary>
        /// Christmas Island (CX)
        /// </summary>
        public static CountryIso2Code ChristmasIsland => new(Iso2Codes.CX);

        /// <summary>
        /// Cyprus (CY)
        /// </summary>
        public static CountryIso2Code Cyprus => new(Iso2Codes.CY);

        /// <summary>
        /// Czech Republic (CZ)
        /// </summary>
        public static CountryIso2Code CzechRepublic => new(Iso2Codes.CZ);

        /// <summary>
        /// Germany (DE)
        /// </summary>
        public static CountryIso2Code Germany => new(Iso2Codes.DE);

        /// <summary>
        /// Djibouti (DJ)
        /// </summary>
        public static CountryIso2Code Djibouti => new(Iso2Codes.DJ);

        /// <summary>
        /// Denmark (DK)
        /// </summary>
        public static CountryIso2Code Denmark => new(Iso2Codes.DK);

        /// <summary>
        /// Dominica (DM)
        /// </summary>
        public static CountryIso2Code Dominica => new(Iso2Codes.DM);

        /// <summary>
        /// Dominican Republic (DO)
        /// </summary>
        public static CountryIso2Code DominicanRepublic => new(Iso2Codes.DO);

        /// <summary>
        /// Algeria (DZ)
        /// </summary>
        public static CountryIso2Code Algeria => new(Iso2Codes.DZ);

        /// <summary>
        /// Ecuador (EC)
        /// </summary>
        public static CountryIso2Code Ecuador => new(Iso2Codes.EC);

        /// <summary>
        /// Estonia (EE)
        /// </summary>
        public static CountryIso2Code Estonia => new(Iso2Codes.EE);

        /// <summary>
        /// Egypt (EG)
        /// </summary>
        public static CountryIso2Code Egypt => new(Iso2Codes.EG);

        /// <summary>
        /// Western Sahara (EH)
        /// </summary>
        public static CountryIso2Code WesternSahara => new(Iso2Codes.EH);

        /// <summary>
        /// Eritrea (ER)
        /// </summary>
        public static CountryIso2Code Eritrea => new(Iso2Codes.ER);

        /// <summary>
        /// Spain (ES)
        /// </summary>
        public static CountryIso2Code Spain => new(Iso2Codes.ES);

        /// <summary>
        /// Ethiopia (ET)
        /// </summary>
        public static CountryIso2Code Ethiopia => new(Iso2Codes.ET);

        /// <summary>
        /// Finland (FI)
        /// </summary>
        public static CountryIso2Code Finland => new(Iso2Codes.FI);

        /// <summary>
        /// Fiji (FJ)
        /// </summary>
        public static CountryIso2Code Fiji => new(Iso2Codes.FJ);

        /// <summary>
        /// Falkland Islands (FK)
        /// </summary>
        public static CountryIso2Code FalklandIslands => new(Iso2Codes.FK);

        /// <summary>
        /// Micronesia (FM)
        /// </summary>
        public static CountryIso2Code Micronesia => new(Iso2Codes.FM);

        /// <summary>
        /// Faroe Islands (FO)
        /// </summary>
        public static CountryIso2Code FaroeIslands => new(Iso2Codes.FO);

        /// <summary>
        /// France (FR)
        /// </summary>
        public static CountryIso2Code France => new(Iso2Codes.FR);

        /// <summary>
        /// Gabon (GA)
        /// </summary>
        public static CountryIso2Code Gabon => new(Iso2Codes.GA);

        /// <summary>
        /// United Kingdom (GB)
        /// </summary>
        public static CountryIso2Code UnitedKingdom => new(Iso2Codes.GB);

        /// <summary>
        /// Grenada (GD)
        /// </summary>
        public static CountryIso2Code Grenada => new(Iso2Codes.GD);

        /// <summary>
        /// Georgia (GE)
        /// </summary>
        public static CountryIso2Code Georgia => new(Iso2Codes.GE);

        /// <summary>
        /// French Guiana (GF)
        /// </summary>
        public static CountryIso2Code FrenchGuiana => new(Iso2Codes.GF);

        /// <summary>
        /// Guernsey (GG)
        /// </summary>
        public static CountryIso2Code Guernsey => new(Iso2Codes.GG);

        /// <summary>
        /// Ghana (GH)
        /// </summary>
        public static CountryIso2Code Ghana => new(Iso2Codes.GH);

        /// <summary>
        /// Gibraltar (GI)
        /// </summary>
        public static CountryIso2Code Gibraltar => new(Iso2Codes.GI);

        /// <summary>
        /// Greenland (GL)
        /// </summary>
        public static CountryIso2Code Greenland => new(Iso2Codes.GL);

        /// <summary>
        /// Gambia (GM)
        /// </summary>
        public static CountryIso2Code Gambia => new(Iso2Codes.GM);

        /// <summary>
        /// Guinea, Republic of (GN)
        /// </summary>
        public static CountryIso2Code GuineaRepublicOf => new(Iso2Codes.GN);

        /// <summary>
        /// Global System (GO)
        /// </summary>
        public static CountryIso2Code GlobalSystem => new(Iso2Codes.GO);

        /// <summary>
        /// Guadeloupe (GP)
        /// </summary>
        public static CountryIso2Code Guadeloupe => new(Iso2Codes.GP);

        /// <summary>
        /// Equatorial Guinea (GQ)
        /// </summary>
        public static CountryIso2Code EquatorialGuinea => new(Iso2Codes.GQ);

        /// <summary>
        /// Greece (GR)
        /// </summary>
        public static CountryIso2Code Greece => new(Iso2Codes.GR);

        /// <summary>
        /// South Georgia (GS)
        /// </summary>
        public static CountryIso2Code SouthGeorgia => new(Iso2Codes.GS);

        /// <summary>
        /// Guatemala (GT)
        /// </summary>
        public static CountryIso2Code Guatemala => new(Iso2Codes.GT);

        /// <summary>
        /// Guam (GU)
        /// </summary>
        public static CountryIso2Code Guam => new(Iso2Codes.GU);

        /// <summary>
        /// Guinea-Bissau (GW)
        /// </summary>
        public static CountryIso2Code GuineaBissau => new(Iso2Codes.GW);

        /// <summary>
        /// Guyana (GY)
        /// </summary>
        public static CountryIso2Code Guyana => new(Iso2Codes.GY);

        /// <summary>
        /// Hong Kong (HK)
        /// </summary>
        public static CountryIso2Code HongKong => new(Iso2Codes.HK);

        /// <summary>
        /// Honduras (HN)
        /// </summary>
        public static CountryIso2Code Honduras => new(Iso2Codes.HN);

        /// <summary>
        /// Croatia (HR)
        /// </summary>
        public static CountryIso2Code Croatia => new(Iso2Codes.HR);

        /// <summary>
        /// Haiti (HT)
        /// </summary>
        public static CountryIso2Code Haiti => new(Iso2Codes.HT);

        /// <summary>
        /// Hungary (HU)
        /// </summary>
        public static CountryIso2Code Hungary => new(Iso2Codes.HU);

        /// <summary>
        /// Indonesia (ID)
        /// </summary>
        public static CountryIso2Code Indonesia => new(Iso2Codes.ID);

        /// <summary>
        /// Ireland (IE)
        /// </summary>
        public static CountryIso2Code Ireland => new(Iso2Codes.IE);

        /// <summary>
        /// Israel (IL)
        /// </summary>
        public static CountryIso2Code Israel => new(Iso2Codes.IL);

        /// <summary>
        /// Isle of Man (IM)
        /// </summary>
        public static CountryIso2Code IsleOfMan => new(Iso2Codes.IM);

        /// <summary>
        /// India (IN)
        /// </summary>
        public static CountryIso2Code India => new(Iso2Codes.IN);

        /// <summary>
        /// British Indian Ocean Territory (IO)
        /// </summary>
        public static CountryIso2Code BritishIndianOceanTerritory => new(Iso2Codes.IO);

        /// <summary>
        /// Iraq (IQ)
        /// </summary>
        public static CountryIso2Code Iraq => new(Iso2Codes.IQ);

        /// <summary>
        /// Iran (IR)
        /// </summary>
        [DataMember(Order = 7)]
        public static CountryIso2Code Iran => new(Iso2Codes.IR);

        /// <summary>
        /// Iceland (IS)
        /// </summary>
        public static CountryIso2Code Iceland => new(Iso2Codes.IS);

        /// <summary>
        /// Italy (IT)
        /// </summary>
        public static CountryIso2Code Italy => new(Iso2Codes.IT);

        /// <summary>
        /// Jersey (JE)
        /// </summary>
        public static CountryIso2Code Jersey => new(Iso2Codes.JE);

        /// <summary>
        /// Jamaica (JM)
        /// </summary>
        public static CountryIso2Code Jamaica => new(Iso2Codes.JM);

        /// <summary>
        /// Jordan (JO)
        /// </summary>
        public static CountryIso2Code Jordan => new(Iso2Codes.JO);

        /// <summary>
        /// Japan (JP)
        /// </summary>
        public static CountryIso2Code Japan => new(Iso2Codes.JP);

        /// <summary>
        /// Kenya (KE)
        /// </summary>
        public static CountryIso2Code Kenya => new(Iso2Codes.KE);

        /// <summary>
        /// Kyrgyzstan (KG)
        /// </summary>
        public static CountryIso2Code Kyrgyzstan => new(Iso2Codes.KG);

        /// <summary>
        /// Cambodia (KH)
        /// </summary>
        public static CountryIso2Code Cambodia => new(Iso2Codes.KH);

        /// <summary>
        /// Kiribati (KI)
        /// </summary>
        public static CountryIso2Code Kiribati => new(Iso2Codes.KI);

        /// <summary>
        /// Comoros (KM)
        /// </summary>
        public static CountryIso2Code Comoros => new(Iso2Codes.KM);

        /// <summary>
        /// Saint Kitts And Nevis (KN)
        /// </summary>
        public static CountryIso2Code SaintKittsAndNevis => new(Iso2Codes.KN);

        /// <summary>
        /// Korea, North (KP)
        /// </summary>
        public static CountryIso2Code KoreaNorth => new(Iso2Codes.KP);

        /// <summary>
        /// Korea, South (KR)
        /// </summary>
        public static CountryIso2Code KoreaSouth => new(Iso2Codes.KR);

        /// <summary>
        /// Kuwait (KW)
        /// </summary>
        public static CountryIso2Code Kuwait => new(Iso2Codes.KW);

        /// <summary>
        /// Cayman Islands (KY)
        /// </summary>
        public static CountryIso2Code CaymanIslands => new(Iso2Codes.KY);

        /// <summary>
        /// Kazakhstan (KZ)
        /// </summary>
        public static CountryIso2Code Kazakhstan => new(Iso2Codes.KZ);

        /// <summary>
        /// Laos (LA)
        /// </summary>
        public static CountryIso2Code Laos => new(Iso2Codes.LA);

        /// <summary>
        /// Lebanon (LB)
        /// </summary>
        public static CountryIso2Code Lebanon => new(Iso2Codes.LB);

        /// <summary>
        /// Saint Lucia (LC)
        /// </summary>
        public static CountryIso2Code SaintLucia => new(Iso2Codes.LC);

        /// <summary>
        /// Liechtenstein (LI)
        /// </summary>
        public static CountryIso2Code Liechtenstein => new(Iso2Codes.LI);

        /// <summary>
        /// Sri Lanka (LK)
        /// </summary>
        public static CountryIso2Code SriLanka => new(Iso2Codes.LK);

        /// <summary>
        /// Liberia (LR)
        /// </summary>
        public static CountryIso2Code Liberia => new(Iso2Codes.LR);

        /// <summary>
        /// Lesotho (LS)
        /// </summary>
        public static CountryIso2Code Lesotho => new(Iso2Codes.LS);

        /// <summary>
        /// Lithuania (LT)
        /// </summary>
        public static CountryIso2Code Lithuania => new(Iso2Codes.LT);

        /// <summary>
        /// Luxembourg (LU)
        /// </summary>
        public static CountryIso2Code Luxembourg => new(Iso2Codes.LU);

        /// <summary>
        /// Latvia (LV)
        /// </summary>
        public static CountryIso2Code Latvia => new(Iso2Codes.LV);

        /// <summary>
        /// Libya (LY)
        /// </summary>
        public static CountryIso2Code Libya => new(Iso2Codes.LY);

        /// <summary>
        /// Morocco (MA)
        /// </summary>
        public static CountryIso2Code Morocco => new(Iso2Codes.MA);

        /// <summary>
        /// Monaco (MC)
        /// </summary>
        public static CountryIso2Code Monaco => new(Iso2Codes.MC);

        /// <summary>
        /// Moldova (MD)
        /// </summary>
        public static CountryIso2Code Moldova => new(Iso2Codes.MD);

        /// <summary>
        /// Montenegro (ME)
        /// </summary>
        public static CountryIso2Code Montenegro => new(Iso2Codes.ME);

        /// <summary>
        /// Madagascar (MG)
        /// </summary>
        public static CountryIso2Code Madagascar => new(Iso2Codes.MG);

        /// <summary>
        /// Marshall islands (MH)
        /// </summary>
        public static CountryIso2Code MarshallIslands => new(Iso2Codes.MH);

        /// <summary>
        /// Macedonia (MK)
        /// </summary>
        public static CountryIso2Code Macedonia => new(Iso2Codes.MK);

        /// <summary>
        /// Mali (ML)
        /// </summary>
        public static CountryIso2Code Mali => new(Iso2Codes.ML);

        /// <summary>
        /// Myanmar (MM)
        /// </summary>
        public static CountryIso2Code Myanmar => new(Iso2Codes.MM);

        /// <summary>
        /// Mongolia (MN)
        /// </summary>
        public static CountryIso2Code Mongolia => new(Iso2Codes.MN);

        /// <summary>
        /// Macau (MO)
        /// </summary>
        public static CountryIso2Code Macau => new(Iso2Codes.MO);

        /// <summary>
        /// Northern Mariana Islands (MP)
        /// </summary>
        public static CountryIso2Code NorthernMarianaIslands => new(Iso2Codes.MP);

        /// <summary>
        /// Martinique (MQ)
        /// </summary>
        public static CountryIso2Code Martinique => new(Iso2Codes.MQ);

        /// <summary>
        /// Mauritania (MR)
        /// </summary>
        public static CountryIso2Code Mauritania => new(Iso2Codes.MR);

        /// <summary>
        /// Montserrat (MS)
        /// </summary>
        public static CountryIso2Code Montserrat => new(Iso2Codes.MS);

        /// <summary>
        /// Malta (MT)
        /// </summary>
        public static CountryIso2Code Malta => new(Iso2Codes.MT);

        /// <summary>
        /// Mauritius (MU)
        /// </summary>
        public static CountryIso2Code Mauritius => new(Iso2Codes.MU);

        /// <summary>
        /// Maldives (MV)
        /// </summary>
        public static CountryIso2Code Maldives => new(Iso2Codes.MV);

        /// <summary>
        /// Malawi (MW)
        /// </summary>
        public static CountryIso2Code Malawi => new(Iso2Codes.MW);

        /// <summary>
        /// Mexico (MX)
        /// </summary>
        public static CountryIso2Code Mexico => new(Iso2Codes.MX);

        /// <summary>
        /// Malaysia (MY)
        /// </summary>
        public static CountryIso2Code Malaysia => new(Iso2Codes.MY);

        /// <summary>
        /// Mozambique (MZ)
        /// </summary>
        public static CountryIso2Code Mozambique => new(Iso2Codes.MZ);

        /// <summary>
        /// Namibia (NA)
        /// </summary>
        public static CountryIso2Code Namibia => new(Iso2Codes.NA);

        /// <summary>
        /// New Caledonia (NC)
        /// </summary>
        public static CountryIso2Code NewCaledonia => new(Iso2Codes.NC);

        /// <summary>
        /// Niger (NE)
        /// </summary>
        public static CountryIso2Code Niger => new(Iso2Codes.NE);

        /// <summary>
        /// Norfolk Island (NF)
        /// </summary>
        public static CountryIso2Code NorfolkIsland => new(Iso2Codes.NF);

        /// <summary>
        /// Nigeria (NG)
        /// </summary>
        public static CountryIso2Code Nigeria => new(Iso2Codes.NG);

        /// <summary>
        /// Nicaragua (NI)
        /// </summary>
        public static CountryIso2Code Nicaragua => new(Iso2Codes.NI);

        /// <summary>
        /// Netherlands, The (NL)
        /// </summary>
        public static CountryIso2Code NetherlandsThe => new(Iso2Codes.NL);

        /// <summary>
        /// Norway (NO)
        /// </summary>
        public static CountryIso2Code Norway => new(Iso2Codes.NO);

        /// <summary>
        /// Nepal (NP)
        /// </summary>
        public static CountryIso2Code Nepal => new(Iso2Codes.NP);

        /// <summary>
        /// Nauru (NR)
        /// </summary>
        public static CountryIso2Code Nauru => new(Iso2Codes.NR);

        /// <summary>
        /// Niue (NU)
        /// </summary>
        public static CountryIso2Code Niue => new(Iso2Codes.NU);

        /// <summary>
        /// New Zealand (NZ)
        /// </summary>
        public static CountryIso2Code NewZealand => new(Iso2Codes.NZ);

        /// <summary>
        /// Oman (OM)
        /// </summary>
        public static CountryIso2Code Oman => new(Iso2Codes.OM);

        /// <summary>
        /// Panama (PA)
        /// </summary>
        public static CountryIso2Code Panama => new(Iso2Codes.PA);

        /// <summary>
        /// Peru (PE)
        /// </summary>
        public static CountryIso2Code Peru => new(Iso2Codes.PE);

        /// <summary>
        /// French Polynesia (PF)
        /// </summary>
        public static CountryIso2Code FrenchPolynesia => new(Iso2Codes.PF);

        /// <summary>
        /// Papua New Guinea (PG)
        /// </summary>
        public static CountryIso2Code PapuaNewGuinea => new(Iso2Codes.PG);

        /// <summary>
        /// Philippines (PH)
        /// </summary>
        public static CountryIso2Code Philippines => new(Iso2Codes.PH);

        /// <summary>
        /// Pakistan (PK)
        /// </summary>
        public static CountryIso2Code Pakistan => new(Iso2Codes.PK);

        /// <summary>
        /// Poland (PL)
        /// </summary>
        public static CountryIso2Code Poland => new(Iso2Codes.PL);

        /// <summary>
        /// Saint Pierre and Miquelon (PM)
        /// </summary>
        public static CountryIso2Code SaintPierreAndMiquelon => new(Iso2Codes.PM);

        /// <summary>
        /// Pitcairn Islands (PN)
        /// </summary>
        public static CountryIso2Code PitcairnIslands => new(Iso2Codes.PN);

        /// <summary>
        /// Puerto Rico (PR)
        /// </summary>
        public static CountryIso2Code PuertoRico => new(Iso2Codes.PR);

        /// <summary>
        /// Palestine (PS)
        /// </summary>
        public static CountryIso2Code Palestine => new(Iso2Codes.PS);

        /// <summary>
        /// Portugal (PT)
        /// </summary>
        public static CountryIso2Code Portugal => new(Iso2Codes.PT);

        /// <summary>
        /// Palau (PW)
        /// </summary>
        public static CountryIso2Code Palau => new(Iso2Codes.PW);

        /// <summary>
        /// Paraguay (PY)
        /// </summary>
        public static CountryIso2Code Paraguay => new(Iso2Codes.PY);

        /// <summary>
        /// Qatar (QA)
        /// </summary>
        public static CountryIso2Code Qatar => new(Iso2Codes.QA);

        /// <summary>
        /// Reunion (RE)
        /// </summary>
        public static CountryIso2Code Reunion => new(Iso2Codes.RE);

        /// <summary>
        /// Romania (RO)
        /// </summary>
        public static CountryIso2Code Romania => new(Iso2Codes.RO);

        /// <summary>
        /// Serbia (RS)
        /// </summary>
        public static CountryIso2Code Serbia => new(Iso2Codes.RS);

        /// <summary>
        /// Russia (RU)
        /// </summary>
        public static CountryIso2Code Russia => new(Iso2Codes.RU);

        /// <summary>
        /// Rwanda (RW)
        /// </summary>
        public static CountryIso2Code Rwanda => new(Iso2Codes.RW);

        /// <summary>
        /// Saudi Arabia (SA)
        /// </summary>
        public static CountryIso2Code SaudiArabia => new(Iso2Codes.SA);

        /// <summary>
        /// Solomon Islands (SB)
        /// </summary>
        public static CountryIso2Code SolomonIslands => new(Iso2Codes.SB);

        /// <summary>
        /// Seychelles (SC)
        /// </summary>
        public static CountryIso2Code Seychelles => new(Iso2Codes.SC);

        /// <summary>
        /// Sudan (SD)
        /// </summary>
        public static CountryIso2Code Sudan => new(Iso2Codes.SD);

        /// <summary>
        /// Sweden (SE)
        /// </summary>
        public static CountryIso2Code Sweden => new(Iso2Codes.SE);

        /// <summary>
        /// Singapore (SG)
        /// </summary>
        public static CountryIso2Code Singapore => new(Iso2Codes.SG);

        /// <summary>
        /// Saint Helena (SH)
        /// </summary>
        public static CountryIso2Code SaintHelena => new(Iso2Codes.SH);

        /// <summary>
        /// Slovenia (SI)
        /// </summary>
        public static CountryIso2Code Slovenia => new(Iso2Codes.SI);

        /// <summary>
        /// Slovakia (SK)
        /// </summary>
        public static CountryIso2Code Slovakia => new(Iso2Codes.SK);

        /// <summary>
        /// Sierra Leone (SL)
        /// </summary>
        public static CountryIso2Code SierraLeone => new(Iso2Codes.SL);

        /// <summary>
        /// San Marino (SM)
        /// </summary>
        public static CountryIso2Code SanMarino => new(Iso2Codes.SM);

        /// <summary>
        /// Senegal (SN)
        /// </summary>
        public static CountryIso2Code Senegal => new(Iso2Codes.SN);

        /// <summary>
        /// Somalia (SO)
        /// </summary>
        public static CountryIso2Code Somalia => new(Iso2Codes.SO);

        /// <summary>
        /// Suriname (SR)
        /// </summary>
        public static CountryIso2Code Suriname => new(Iso2Codes.SR);

        /// <summary>
        /// South Sudan (SS)
        /// </summary>
        public static CountryIso2Code SouthSudan => new(Iso2Codes.SS);

        /// <summary>
        /// Sao Tome and Principe (ST)
        /// </summary>
        public static CountryIso2Code SaoTomeAndPrincipe => new(Iso2Codes.ST);

        /// <summary>
        /// El Salvador (SV)
        /// </summary>
        public static CountryIso2Code ElSalvador => new(Iso2Codes.SV);

        /// <summary>
        /// Sint Maarten (SX)
        /// </summary>
        public static CountryIso2Code SintMaarten => new(Iso2Codes.SX);

        /// <summary>
        /// Syria (SY)
        /// </summary>
        public static CountryIso2Code Syria => new(Iso2Codes.SY);

        /// <summary>
        /// Swaziland (SZ)
        /// </summary>
        public static CountryIso2Code Swaziland => new(Iso2Codes.SZ);

        /// <summary>
        /// Tristan da Cunha (TA)
        /// </summary>
        public static CountryIso2Code TristanDaCunha => new(Iso2Codes.TA);

        /// <summary>
        /// Turks And Caicos Islands (TC)
        /// </summary>
        public static CountryIso2Code TurksAndCaicosIslands => new(Iso2Codes.TC);

        /// <summary>
        /// Chad (TD)
        /// </summary>
        public static CountryIso2Code Chad => new(Iso2Codes.TD);

        /// <summary>
        /// Togo (TG)
        /// </summary>
        public static CountryIso2Code Togo => new(Iso2Codes.TG);

        /// <summary>
        /// Thailand (TH)
        /// </summary>
        public static CountryIso2Code Thailand => new(Iso2Codes.TH);

        /// <summary>
        /// Tajikistan (TJ)
        /// </summary>
        public static CountryIso2Code Tajikistan => new(Iso2Codes.TJ);

        /// <summary>
        /// Tokelau (TK)
        /// </summary>
        public static CountryIso2Code Tokelau => new(Iso2Codes.TK);

        /// <summary>
        /// East Timor (TL)
        /// </summary>
        public static CountryIso2Code EastTimor => new(Iso2Codes.TL);

        /// <summary>
        /// Turkmenistan (TM)
        /// </summary>
        public static CountryIso2Code Turkmenistan => new(Iso2Codes.TM);

        /// <summary>
        /// Tunisia (TN)
        /// </summary>
        public static CountryIso2Code Tunisia => new(Iso2Codes.TN);

        /// <summary>
        /// Tonga (TO)
        /// </summary>
        public static CountryIso2Code Tonga => new(Iso2Codes.TO);

        /// <summary>
        /// Turkey (TR)
        /// </summary>
        public static CountryIso2Code Turkey => new(Iso2Codes.TR);

        /// <summary>
        /// Trinidad And Tobago (TT)
        /// </summary>
        public static CountryIso2Code TrinidadAndTobago => new(Iso2Codes.TT);

        /// <summary>
        /// Tuvalu (TV)
        /// </summary>
        public static CountryIso2Code Tuvalu => new(Iso2Codes.TV);

        /// <summary>
        /// Taiwan (TW)
        /// </summary>
        public static CountryIso2Code Taiwan => new(Iso2Codes.TW);

        /// <summary>
        /// Tanzania (TZ)
        /// </summary>
        public static CountryIso2Code Tanzania => new(Iso2Codes.TZ);

        /// <summary>
        /// Ukraine (UA)
        /// </summary>
        public static CountryIso2Code Ukraine => new(Iso2Codes.UA);

        /// <summary>
        /// Uganda (UG)
        /// </summary>
        public static CountryIso2Code Uganda => new(Iso2Codes.UG);

        /// <summary>
        /// United States (US)
        /// </summary>
        public static CountryIso2Code UnitedStates => new(Iso2Codes.US);

        /// <summary>
        /// Uruguay (UY)
        /// </summary>
        public static CountryIso2Code Uruguay => new(Iso2Codes.UY);

        /// <summary>
        /// Uzbekistan (UZ)
        /// </summary>
        public static CountryIso2Code Uzbekistan => new(Iso2Codes.UZ);

        /// <summary>
        /// Vatican City (VA)
        /// </summary>
        public static CountryIso2Code VaticanCity => new(Iso2Codes.VA);

        /// <summary>
        /// Saint Vincent and the Grenadines (VC)
        /// </summary>
        public static CountryIso2Code SaintVincentAndTheGrenadines => new(Iso2Codes.VC);

        /// <summary>
        /// Venezuela (VE)
        /// </summary>
        public static CountryIso2Code Venezuela => new(Iso2Codes.VE);

        /// <summary>
        /// British Virgin Islands (VG)
        /// </summary>
        public static CountryIso2Code BritishVirginIslands => new(Iso2Codes.VG);

        /// <summary>
        /// US Virgin Islands (VI)
        /// </summary>
        public static CountryIso2Code UsVirginIslands => new(Iso2Codes.VI);

        /// <summary>
        /// Vietnam (VN)
        /// </summary>
        public static CountryIso2Code Vietnam => new(Iso2Codes.VN);

        /// <summary>
        /// Vanuatu (VU)
        /// </summary>
        public static CountryIso2Code Vanuatu => new(Iso2Codes.VU);

        /// <summary>
        /// Wallis And Futuna (WF)
        /// </summary>
        public static CountryIso2Code WallisAndFutuna => new(Iso2Codes.WF);

        /// <summary>
        /// Samoa (WS)
        /// </summary>
        public static CountryIso2Code Samoa => new(Iso2Codes.WS);

        /// <summary>
        /// Kosovo (XK)
        /// </summary>
        public static CountryIso2Code Kosovo => new(Iso2Codes.XK);

        /// <summary>
        /// Inmarsat (XN)
        /// </summary>
        public static CountryIso2Code Inmarsat => new(Iso2Codes.XN);

        /// <summary>
        /// Yemen (YE)
        /// </summary>
        public static CountryIso2Code Yemen => new(Iso2Codes.YE);

        /// <summary>
        /// Mayotte (YT)
        /// </summary>
        public static CountryIso2Code Mayotte => new(Iso2Codes.YT);

        /// <summary>
        /// South Africa (ZA)
        /// </summary>
        public static CountryIso2Code SouthAfrica => new(Iso2Codes.ZA);

        /// <summary>
        /// Zambia (ZM)
        /// </summary>
        public static CountryIso2Code Zambia => new(Iso2Codes.ZM);

        /// <summary>
        /// Zimbabwe (ZW)
        /// </summary>
        public static CountryIso2Code Zimbabwe => new(Iso2Codes.ZW);

        #endregion
    }
}