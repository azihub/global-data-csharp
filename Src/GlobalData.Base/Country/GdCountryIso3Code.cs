using System.Collections.Generic;
using GlobalData.Base.Country.Exceptions;

namespace GlobalData.Base.Country
{
    public class GdCountryIso3Code
    {
        private GdCountryIso3Code(string code)
        {
            Code = code;
        }

        public string Code { get; }

        public override string ToString()
        {
            return Code;
        }

        #region Dictionary
        /// <summary>
        /// Hold all countries in private memory space
        /// </summary>
        private static Dictionary<string, GdCountryIso3Code> Codes { get; } = new()
        {
            { Iso3Codes.ABK, new GdCountryIso3Code(Iso3Codes.ABK) }, // Abkhazia
            { Iso3Codes.ABW, new GdCountryIso3Code(Iso3Codes.ABW) }, // Aruba
            { Iso3Codes.AFG, new GdCountryIso3Code(Iso3Codes.AFG) }, // Afghanistan
            { Iso3Codes.AGO, new GdCountryIso3Code(Iso3Codes.AGO) }, // Angola
            { Iso3Codes.AIA, new GdCountryIso3Code(Iso3Codes.AIA) }, // Anguilla
            { Iso3Codes.ALA, new GdCountryIso3Code(Iso3Codes.ALA) }, // Aland Islands
            { Iso3Codes.ALB, new GdCountryIso3Code(Iso3Codes.ALB) }, // Albania
            { Iso3Codes.AND, new GdCountryIso3Code(Iso3Codes.AND) }, // Andorra
            { Iso3Codes.ANT, new GdCountryIso3Code(Iso3Codes.ANT) }, // Netherlands Antilles
            { Iso3Codes.ARE, new GdCountryIso3Code(Iso3Codes.ARE) }, // United Arab Emirates
            { Iso3Codes.ARG, new GdCountryIso3Code(Iso3Codes.ARG) }, // Argentina
            { Iso3Codes.ARM, new GdCountryIso3Code(Iso3Codes.ARM) }, // Armenia
            { Iso3Codes.ASC, new GdCountryIso3Code(Iso3Codes.ASC) }, // Ascension Island
            { Iso3Codes.ASM, new GdCountryIso3Code(Iso3Codes.ASM) }, // American Samoa
            { Iso3Codes.ATA, new GdCountryIso3Code(Iso3Codes.ATA) }, // Antarctica
            { Iso3Codes.ATG, new GdCountryIso3Code(Iso3Codes.ATG) }, // Antigua And Barbuda
            { Iso3Codes.AUS, new GdCountryIso3Code(Iso3Codes.AUS) }, // Australia
            { Iso3Codes.AUT, new GdCountryIso3Code(Iso3Codes.AUT) }, // Austria
            { Iso3Codes.AZE, new GdCountryIso3Code(Iso3Codes.AZE) }, // Azerbaijan
            { Iso3Codes.BDI, new GdCountryIso3Code(Iso3Codes.BDI) }, // Burundi
            { Iso3Codes.BEL, new GdCountryIso3Code(Iso3Codes.BEL) }, // Belgium
            { Iso3Codes.BEN, new GdCountryIso3Code(Iso3Codes.BEN) }, // Benin
            { Iso3Codes.BFA, new GdCountryIso3Code(Iso3Codes.BFA) }, // Burkina Faso
            { Iso3Codes.BGD, new GdCountryIso3Code(Iso3Codes.BGD) }, // Bangladesh
            { Iso3Codes.BGR, new GdCountryIso3Code(Iso3Codes.BGR) }, // Bulgaria
            { Iso3Codes.BHR, new GdCountryIso3Code(Iso3Codes.BHR) }, // Bahrain
            { Iso3Codes.BHS, new GdCountryIso3Code(Iso3Codes.BHS) }, // Bahamas
            { Iso3Codes.BIH, new GdCountryIso3Code(Iso3Codes.BIH) }, // Bosnia And Herzegovina
            { Iso3Codes.BLR, new GdCountryIso3Code(Iso3Codes.BLR) }, // Belarus
            { Iso3Codes.BLZ, new GdCountryIso3Code(Iso3Codes.BLZ) }, // Belize
            { Iso3Codes.BMU, new GdCountryIso3Code(Iso3Codes.BMU) }, // Bermuda
            { Iso3Codes.BOL, new GdCountryIso3Code(Iso3Codes.BOL) }, // Bolivia
            { Iso3Codes.BRA, new GdCountryIso3Code(Iso3Codes.BRA) }, // Brazil
            { Iso3Codes.BRB, new GdCountryIso3Code(Iso3Codes.BRB) }, // Barbados
            { Iso3Codes.BRN, new GdCountryIso3Code(Iso3Codes.BRN) }, // Brunei Darussalam
            { Iso3Codes.BTN, new GdCountryIso3Code(Iso3Codes.BTN) }, // Bhutan
            { Iso3Codes.BWA, new GdCountryIso3Code(Iso3Codes.BWA) }, // Botswana
            { Iso3Codes.CAF, new GdCountryIso3Code(Iso3Codes.CAF) }, // Central African Republic
            { Iso3Codes.CAN, new GdCountryIso3Code(Iso3Codes.CAN) }, // Canada
            { Iso3Codes.CCK, new GdCountryIso3Code(Iso3Codes.CCK) }, // Cocos (Keeling) Islands
            { Iso3Codes.CHE, new GdCountryIso3Code(Iso3Codes.CHE) }, // Switzerland
            { Iso3Codes.CHL, new GdCountryIso3Code(Iso3Codes.CHL) }, // Chile
            { Iso3Codes.CHN, new GdCountryIso3Code(Iso3Codes.CHN) }, // China
            { Iso3Codes.CIV, new GdCountryIso3Code(Iso3Codes.CIV) }, // Ivory Coast
            { Iso3Codes.CMR, new GdCountryIso3Code(Iso3Codes.CMR) }, // Cameroon
            { Iso3Codes.COD, new GdCountryIso3Code(Iso3Codes.COD) }, // Congo, Democratic Republic of the
            { Iso3Codes.COG, new GdCountryIso3Code(Iso3Codes.COG) }, // Congo, Republic of the
            { Iso3Codes.COK, new GdCountryIso3Code(Iso3Codes.COK) }, // Cook Islands
            { Iso3Codes.COL, new GdCountryIso3Code(Iso3Codes.COL) }, // Colombia
            { Iso3Codes.COM, new GdCountryIso3Code(Iso3Codes.COM) }, // Comoros
            { Iso3Codes.CPV, new GdCountryIso3Code(Iso3Codes.CPV) }, // Cape Verde
            { Iso3Codes.CRI, new GdCountryIso3Code(Iso3Codes.CRI) }, // Costa Rica
            { Iso3Codes.CUB, new GdCountryIso3Code(Iso3Codes.CUB) }, // Cuba
            { Iso3Codes.CXR, new GdCountryIso3Code(Iso3Codes.CXR) }, // Christmas Island
            { Iso3Codes.CYM, new GdCountryIso3Code(Iso3Codes.CYM) }, // Cayman Islands
            { Iso3Codes.CYP, new GdCountryIso3Code(Iso3Codes.CYP) }, // Cyprus
            { Iso3Codes.CZE, new GdCountryIso3Code(Iso3Codes.CZE) }, // Czech Republic
            { Iso3Codes.DEU, new GdCountryIso3Code(Iso3Codes.DEU) }, // Germany
            { Iso3Codes.DJI, new GdCountryIso3Code(Iso3Codes.DJI) }, // Djibouti
            { Iso3Codes.DMA, new GdCountryIso3Code(Iso3Codes.DMA) }, // Dominica
            { Iso3Codes.DNK, new GdCountryIso3Code(Iso3Codes.DNK) }, // Denmark
            { Iso3Codes.DOM, new GdCountryIso3Code(Iso3Codes.DOM) }, // Dominican Republic
            { Iso3Codes.DZA, new GdCountryIso3Code(Iso3Codes.DZA) }, // Algeria
            { Iso3Codes.ECU, new GdCountryIso3Code(Iso3Codes.ECU) }, // Ecuador
            { Iso3Codes.EGY, new GdCountryIso3Code(Iso3Codes.EGY) }, // Egypt
            { Iso3Codes.ERI, new GdCountryIso3Code(Iso3Codes.ERI) }, // Eritrea
            { Iso3Codes.ESH, new GdCountryIso3Code(Iso3Codes.ESH) }, // Western Sahara
            { Iso3Codes.ESP, new GdCountryIso3Code(Iso3Codes.ESP) }, // Spain
            { Iso3Codes.EST, new GdCountryIso3Code(Iso3Codes.EST) }, // Estonia
            { Iso3Codes.ETH, new GdCountryIso3Code(Iso3Codes.ETH) }, // Ethiopia
            { Iso3Codes.FIN, new GdCountryIso3Code(Iso3Codes.FIN) }, // Finland
            { Iso3Codes.FJI, new GdCountryIso3Code(Iso3Codes.FJI) }, // Fiji
            { Iso3Codes.FLK, new GdCountryIso3Code(Iso3Codes.FLK) }, // Falkland Islands
            { Iso3Codes.FRA, new GdCountryIso3Code(Iso3Codes.FRA) }, // France
            { Iso3Codes.FRO, new GdCountryIso3Code(Iso3Codes.FRO) }, // Faroe Islands
            { Iso3Codes.FSM, new GdCountryIso3Code(Iso3Codes.FSM) }, // Micronesia
            { Iso3Codes.GAB, new GdCountryIso3Code(Iso3Codes.GAB) }, // Gabon
            { Iso3Codes.GBR, new GdCountryIso3Code(Iso3Codes.GBR) }, // United Kingdom
            { Iso3Codes.GEO, new GdCountryIso3Code(Iso3Codes.GEO) }, // Georgia
            { Iso3Codes.GGY, new GdCountryIso3Code(Iso3Codes.GGY) }, // Guernsey
            { Iso3Codes.GHA, new GdCountryIso3Code(Iso3Codes.GHA) }, // Ghana
            { Iso3Codes.GIB, new GdCountryIso3Code(Iso3Codes.GIB) }, // Gibraltar
            { Iso3Codes.GIN, new GdCountryIso3Code(Iso3Codes.GIN) }, // Guinea, Republic of
            { Iso3Codes.GLP, new GdCountryIso3Code(Iso3Codes.GLP) }, // Guadeloupe
            { Iso3Codes.GMB, new GdCountryIso3Code(Iso3Codes.GMB) }, // Gambia
            { Iso3Codes.GMS, new GdCountryIso3Code(Iso3Codes.GMS) }, // Global System
            { Iso3Codes.GNB, new GdCountryIso3Code(Iso3Codes.GNB) }, // Guinea-Bissau
            { Iso3Codes.GNQ, new GdCountryIso3Code(Iso3Codes.GNQ) }, // Equatorial Guinea
            { Iso3Codes.GRC, new GdCountryIso3Code(Iso3Codes.GRC) }, // Greece
            { Iso3Codes.GRD, new GdCountryIso3Code(Iso3Codes.GRD) }, // Grenada
            { Iso3Codes.GRL, new GdCountryIso3Code(Iso3Codes.GRL) }, // Greenland
            { Iso3Codes.GTM, new GdCountryIso3Code(Iso3Codes.GTM) }, // Guatemala
            { Iso3Codes.GUF, new GdCountryIso3Code(Iso3Codes.GUF) }, // French Guiana
            { Iso3Codes.GUM, new GdCountryIso3Code(Iso3Codes.GUM) }, // Guam
            { Iso3Codes.GUY, new GdCountryIso3Code(Iso3Codes.GUY) }, // Guyana
            { Iso3Codes.HKG, new GdCountryIso3Code(Iso3Codes.HKG) }, // Hong Kong
            { Iso3Codes.HND, new GdCountryIso3Code(Iso3Codes.HND) }, // Honduras
            { Iso3Codes.HRV, new GdCountryIso3Code(Iso3Codes.HRV) }, // Croatia
            { Iso3Codes.HTI, new GdCountryIso3Code(Iso3Codes.HTI) }, // Haiti
            { Iso3Codes.HUN, new GdCountryIso3Code(Iso3Codes.HUN) }, // Hungary
            { Iso3Codes.IDN, new GdCountryIso3Code(Iso3Codes.IDN) }, // Indonesia
            { Iso3Codes.IMN, new GdCountryIso3Code(Iso3Codes.IMN) }, // Isle of Man
            { Iso3Codes.IND, new GdCountryIso3Code(Iso3Codes.IND) }, // India
            { Iso3Codes.IOT, new GdCountryIso3Code(Iso3Codes.IOT) }, // British Indian Ocean Territory
            { Iso3Codes.IRL, new GdCountryIso3Code(Iso3Codes.IRL) }, // Ireland
            { Iso3Codes.IRN, new GdCountryIso3Code(Iso3Codes.IRN) }, // Iran
            { Iso3Codes.IRQ, new GdCountryIso3Code(Iso3Codes.IRQ) }, // Iraq
            { Iso3Codes.ISL, new GdCountryIso3Code(Iso3Codes.ISL) }, // Iceland
            { Iso3Codes.ISR, new GdCountryIso3Code(Iso3Codes.ISR) }, // Israel
            { Iso3Codes.ITA, new GdCountryIso3Code(Iso3Codes.ITA) }, // Italy
            { Iso3Codes.JAM, new GdCountryIso3Code(Iso3Codes.JAM) }, // Jamaica
            { Iso3Codes.JEY, new GdCountryIso3Code(Iso3Codes.JEY) }, // Jersey
            { Iso3Codes.JOR, new GdCountryIso3Code(Iso3Codes.JOR) }, // Jordan
            { Iso3Codes.JPN, new GdCountryIso3Code(Iso3Codes.JPN) }, // Japan
            { Iso3Codes.KAZ, new GdCountryIso3Code(Iso3Codes.KAZ) }, // Kazakhstan
            { Iso3Codes.KEN, new GdCountryIso3Code(Iso3Codes.KEN) }, // Kenya
            { Iso3Codes.KGZ, new GdCountryIso3Code(Iso3Codes.KGZ) }, // Kyrgyzstan
            { Iso3Codes.KHM, new GdCountryIso3Code(Iso3Codes.KHM) }, // Cambodia
            { Iso3Codes.KIR, new GdCountryIso3Code(Iso3Codes.KIR) }, // Kiribati
            { Iso3Codes.KNA, new GdCountryIso3Code(Iso3Codes.KNA) }, // Saint Kitts And Nevis
            { Iso3Codes.KOR, new GdCountryIso3Code(Iso3Codes.KOR) }, // Korea, South
            { Iso3Codes.KWT, new GdCountryIso3Code(Iso3Codes.KWT) }, // Kuwait
            { Iso3Codes.LAO, new GdCountryIso3Code(Iso3Codes.LAO) }, // Laos
            { Iso3Codes.LBN, new GdCountryIso3Code(Iso3Codes.LBN) }, // Lebanon
            { Iso3Codes.LBR, new GdCountryIso3Code(Iso3Codes.LBR) }, // Liberia
            { Iso3Codes.LBY, new GdCountryIso3Code(Iso3Codes.LBY) }, // Libya
            { Iso3Codes.LCA, new GdCountryIso3Code(Iso3Codes.LCA) }, // Saint Lucia
            { Iso3Codes.LIE, new GdCountryIso3Code(Iso3Codes.LIE) }, // Liechtenstein
            { Iso3Codes.LKA, new GdCountryIso3Code(Iso3Codes.LKA) }, // Sri Lanka
            { Iso3Codes.LSO, new GdCountryIso3Code(Iso3Codes.LSO) }, // Lesotho
            { Iso3Codes.LTU, new GdCountryIso3Code(Iso3Codes.LTU) }, // Lithuania
            { Iso3Codes.LUX, new GdCountryIso3Code(Iso3Codes.LUX) }, // Luxembourg
            { Iso3Codes.LVA, new GdCountryIso3Code(Iso3Codes.LVA) }, // Latvia
            { Iso3Codes.MAC, new GdCountryIso3Code(Iso3Codes.MAC) }, // Macau
            { Iso3Codes.MAR, new GdCountryIso3Code(Iso3Codes.MAR) }, // Morocco
            { Iso3Codes.MCO, new GdCountryIso3Code(Iso3Codes.MCO) }, // Monaco
            { Iso3Codes.MDA, new GdCountryIso3Code(Iso3Codes.MDA) }, // Moldova
            { Iso3Codes.MDG, new GdCountryIso3Code(Iso3Codes.MDG) }, // Madagascar
            { Iso3Codes.MDV, new GdCountryIso3Code(Iso3Codes.MDV) }, // Maldives
            { Iso3Codes.MEX, new GdCountryIso3Code(Iso3Codes.MEX) }, // Mexico
            { Iso3Codes.MHL, new GdCountryIso3Code(Iso3Codes.MHL) }, // Marshall islands
            { Iso3Codes.MKD, new GdCountryIso3Code(Iso3Codes.MKD) }, // Macedonia
            { Iso3Codes.MLI, new GdCountryIso3Code(Iso3Codes.MLI) }, // Mali
            { Iso3Codes.MLT, new GdCountryIso3Code(Iso3Codes.MLT) }, // Malta
            { Iso3Codes.MMR, new GdCountryIso3Code(Iso3Codes.MMR) }, // Myanmar
            { Iso3Codes.MNE, new GdCountryIso3Code(Iso3Codes.MNE) }, // Montenegro
            { Iso3Codes.MNG, new GdCountryIso3Code(Iso3Codes.MNG) }, // Mongolia
            { Iso3Codes.MNP, new GdCountryIso3Code(Iso3Codes.MNP) }, // Northern Mariana Islands
            { Iso3Codes.MOZ, new GdCountryIso3Code(Iso3Codes.MOZ) }, // Mozambique
            { Iso3Codes.MRT, new GdCountryIso3Code(Iso3Codes.MRT) }, // Mauritania
            { Iso3Codes.MSR, new GdCountryIso3Code(Iso3Codes.MSR) }, // Montserrat
            { Iso3Codes.MTQ, new GdCountryIso3Code(Iso3Codes.MTQ) }, // Martinique
            { Iso3Codes.MUS, new GdCountryIso3Code(Iso3Codes.MUS) }, // Mauritius
            { Iso3Codes.MWI, new GdCountryIso3Code(Iso3Codes.MWI) }, // Malawi
            { Iso3Codes.MYS, new GdCountryIso3Code(Iso3Codes.MYS) }, // Malaysia
            { Iso3Codes.MYT, new GdCountryIso3Code(Iso3Codes.MYT) }, // Mayotte
            { Iso3Codes.NAM, new GdCountryIso3Code(Iso3Codes.NAM) }, // Namibia
            { Iso3Codes.NCL, new GdCountryIso3Code(Iso3Codes.NCL) }, // New Caledonia
            { Iso3Codes.NER, new GdCountryIso3Code(Iso3Codes.NER) }, // Niger
            { Iso3Codes.NFK, new GdCountryIso3Code(Iso3Codes.NFK) }, // Norfolk Island
            { Iso3Codes.NGA, new GdCountryIso3Code(Iso3Codes.NGA) }, // Nigeria
            { Iso3Codes.NIC, new GdCountryIso3Code(Iso3Codes.NIC) }, // Nicaragua
            { Iso3Codes.NIU, new GdCountryIso3Code(Iso3Codes.NIU) }, // Niue
            { Iso3Codes.NLD, new GdCountryIso3Code(Iso3Codes.NLD) }, // Netherlands, The
            { Iso3Codes.NOR, new GdCountryIso3Code(Iso3Codes.NOR) }, // Norway
            { Iso3Codes.NPL, new GdCountryIso3Code(Iso3Codes.NPL) }, // Nepal
            { Iso3Codes.NRU, new GdCountryIso3Code(Iso3Codes.NRU) }, // Nauru
            { Iso3Codes.NZL, new GdCountryIso3Code(Iso3Codes.NZL) }, // New Zealand
            { Iso3Codes.OMN, new GdCountryIso3Code(Iso3Codes.OMN) }, // Oman
            { Iso3Codes.PAK, new GdCountryIso3Code(Iso3Codes.PAK) }, // Pakistan
            { Iso3Codes.PAN, new GdCountryIso3Code(Iso3Codes.PAN) }, // Panama
            { Iso3Codes.PCN, new GdCountryIso3Code(Iso3Codes.PCN) }, // Pitcairn Islands
            { Iso3Codes.PER, new GdCountryIso3Code(Iso3Codes.PER) }, // Peru
            { Iso3Codes.PHL, new GdCountryIso3Code(Iso3Codes.PHL) }, // Philippines
            { Iso3Codes.PLW, new GdCountryIso3Code(Iso3Codes.PLW) }, // Palau
            { Iso3Codes.PNG, new GdCountryIso3Code(Iso3Codes.PNG) }, // Papua New Guinea
            { Iso3Codes.POL, new GdCountryIso3Code(Iso3Codes.POL) }, // Poland
            { Iso3Codes.PRI, new GdCountryIso3Code(Iso3Codes.PRI) }, // Puerto Rico
            { Iso3Codes.PRK, new GdCountryIso3Code(Iso3Codes.PRK) }, // Korea, North
            { Iso3Codes.PRT, new GdCountryIso3Code(Iso3Codes.PRT) }, // Portugal
            { Iso3Codes.PRY, new GdCountryIso3Code(Iso3Codes.PRY) }, // Paraguay
            { Iso3Codes.PSE, new GdCountryIso3Code(Iso3Codes.PSE) }, // Palestine
            { Iso3Codes.PYF, new GdCountryIso3Code(Iso3Codes.PYF) }, // French Polynesia
            { Iso3Codes.QAT, new GdCountryIso3Code(Iso3Codes.QAT) }, // Qatar
            { Iso3Codes.REU, new GdCountryIso3Code(Iso3Codes.REU) }, // Reunion
            { Iso3Codes.ROU, new GdCountryIso3Code(Iso3Codes.ROU) }, // Romania
            { Iso3Codes.RUS, new GdCountryIso3Code(Iso3Codes.RUS) }, // Russia
            { Iso3Codes.RWA, new GdCountryIso3Code(Iso3Codes.RWA) }, // Rwanda
            { Iso3Codes.SAU, new GdCountryIso3Code(Iso3Codes.SAU) }, // Saudi Arabia
            { Iso3Codes.SDN, new GdCountryIso3Code(Iso3Codes.SDN) }, // Sudan
            { Iso3Codes.SEN, new GdCountryIso3Code(Iso3Codes.SEN) }, // Senegal
            { Iso3Codes.SGP, new GdCountryIso3Code(Iso3Codes.SGP) }, // Singapore
            { Iso3Codes.SGS, new GdCountryIso3Code(Iso3Codes.SGS) }, // South Georgia
            { Iso3Codes.SHN, new GdCountryIso3Code(Iso3Codes.SHN) }, // Saint Helena
            { Iso3Codes.SLB, new GdCountryIso3Code(Iso3Codes.SLB) }, // Solomon Islands
            { Iso3Codes.SLE, new GdCountryIso3Code(Iso3Codes.SLE) }, // Sierra Leone
            { Iso3Codes.SLV, new GdCountryIso3Code(Iso3Codes.SLV) }, // El Salvador
            { Iso3Codes.SMR, new GdCountryIso3Code(Iso3Codes.SMR) }, // San Marino
            { Iso3Codes.SOM, new GdCountryIso3Code(Iso3Codes.SOM) }, // Somalia
            { Iso3Codes.SPM, new GdCountryIso3Code(Iso3Codes.SPM) }, // Saint Pierre and Miquelon
            { Iso3Codes.SRB, new GdCountryIso3Code(Iso3Codes.SRB) }, // Serbia
            { Iso3Codes.SSD, new GdCountryIso3Code(Iso3Codes.SSD) }, // South Sudan
            { Iso3Codes.STP, new GdCountryIso3Code(Iso3Codes.STP) }, // Sao Tome and Principe
            { Iso3Codes.SUR, new GdCountryIso3Code(Iso3Codes.SUR) }, // Suriname
            { Iso3Codes.SVK, new GdCountryIso3Code(Iso3Codes.SVK) }, // Slovakia
            { Iso3Codes.SVN, new GdCountryIso3Code(Iso3Codes.SVN) }, // Slovenia
            { Iso3Codes.SWE, new GdCountryIso3Code(Iso3Codes.SWE) }, // Sweden
            { Iso3Codes.SWZ, new GdCountryIso3Code(Iso3Codes.SWZ) }, // Swaziland
            { Iso3Codes.SXM, new GdCountryIso3Code(Iso3Codes.SXM) }, // Sint Maarten
            { Iso3Codes.SYC, new GdCountryIso3Code(Iso3Codes.SYC) }, // Seychelles
            { Iso3Codes.SYR, new GdCountryIso3Code(Iso3Codes.SYR) }, // Syria
            { Iso3Codes.TAA, new GdCountryIso3Code(Iso3Codes.TAA) }, // Tristan da Cunha
            { Iso3Codes.TCA, new GdCountryIso3Code(Iso3Codes.TCA) }, // Turks And Caicos Islands
            { Iso3Codes.TCD, new GdCountryIso3Code(Iso3Codes.TCD) }, // Chad
            { Iso3Codes.TGO, new GdCountryIso3Code(Iso3Codes.TGO) }, // Togo
            { Iso3Codes.THA, new GdCountryIso3Code(Iso3Codes.THA) }, // Thailand
            { Iso3Codes.TJK, new GdCountryIso3Code(Iso3Codes.TJK) }, // Tajikistan
            { Iso3Codes.TKL, new GdCountryIso3Code(Iso3Codes.TKL) }, // Tokelau
            { Iso3Codes.TKM, new GdCountryIso3Code(Iso3Codes.TKM) }, // Turkmenistan
            { Iso3Codes.TMP, new GdCountryIso3Code(Iso3Codes.TMP) }, // East Timor
            { Iso3Codes.TON, new GdCountryIso3Code(Iso3Codes.TON) }, // Tonga
            { Iso3Codes.TTO, new GdCountryIso3Code(Iso3Codes.TTO) }, // Trinidad And Tobago
            { Iso3Codes.TUN, new GdCountryIso3Code(Iso3Codes.TUN) }, // Tunisia
            { Iso3Codes.TUR, new GdCountryIso3Code(Iso3Codes.TUR) }, // Turkey
            { Iso3Codes.TUV, new GdCountryIso3Code(Iso3Codes.TUV) }, // Tuvalu
            { Iso3Codes.TWN, new GdCountryIso3Code(Iso3Codes.TWN) }, // Taiwan
            { Iso3Codes.TZA, new GdCountryIso3Code(Iso3Codes.TZA) }, // Tanzania
            { Iso3Codes.UGA, new GdCountryIso3Code(Iso3Codes.UGA) }, // Uganda
            { Iso3Codes.UKR, new GdCountryIso3Code(Iso3Codes.UKR) }, // Ukraine
            { Iso3Codes.UNK, new GdCountryIso3Code(Iso3Codes.UNK) }, // Kosovo
            { Iso3Codes.URY, new GdCountryIso3Code(Iso3Codes.URY) }, // Uruguay
            { Iso3Codes.USA, new GdCountryIso3Code(Iso3Codes.USA) }, // United States
            { Iso3Codes.UZB, new GdCountryIso3Code(Iso3Codes.UZB) }, // Uzbekistan
            { Iso3Codes.VAT, new GdCountryIso3Code(Iso3Codes.VAT) }, // Vatican City
            { Iso3Codes.VCT, new GdCountryIso3Code(Iso3Codes.VCT) }, // Saint Vincent and the Grenadines
            { Iso3Codes.VEN, new GdCountryIso3Code(Iso3Codes.VEN) }, // Venezuela
            { Iso3Codes.VGB, new GdCountryIso3Code(Iso3Codes.VGB) }, // British Virgin Islands
            { Iso3Codes.VIR, new GdCountryIso3Code(Iso3Codes.VIR) }, // US Virgin Islands
            { Iso3Codes.VNM, new GdCountryIso3Code(Iso3Codes.VNM) }, // Vietnam
            { Iso3Codes.VUT, new GdCountryIso3Code(Iso3Codes.VUT) }, // Vanuatu
            { Iso3Codes.WLF, new GdCountryIso3Code(Iso3Codes.WLF) }, // Wallis And Futuna
            { Iso3Codes.WSM, new GdCountryIso3Code(Iso3Codes.WSM) }, // Samoa
            { Iso3Codes.XNM, new GdCountryIso3Code(Iso3Codes.XNM) }, // Inmarsat
            { Iso3Codes.YEM, new GdCountryIso3Code(Iso3Codes.YEM) }, // Yemen
            { Iso3Codes.ZAF, new GdCountryIso3Code(Iso3Codes.ZAF) }, // South Africa
            { Iso3Codes.ZMB, new GdCountryIso3Code(Iso3Codes.ZMB) }, // Zambia
            { Iso3Codes.ZWE, new GdCountryIso3Code(Iso3Codes.ZWE) }, // Zimbabwe
        };
        #endregion

        /// <summary>
        /// Create GdCountryCode from string value (case insensitive)
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static GdCountryIso3Code FromString(string code)
        {
            if (string.IsNullOrEmpty(code))
                throw new InvalidCountryCodeException(code);


            code = code.Trim().ToUpper();
            if (Codes.TryGetValue(code, out GdCountryIso3Code gdCountryCode))
                return gdCountryCode;

            throw new InvalidCountryCodeException(code);
        }

        #region Country Name
        /// <summary>
        /// Abkhazia (ABK)
        /// </summary>
        public static GdCountryIso3Code Abkhazia => new(Iso3Codes.ABK);

        /// <summary>
        /// Ascension Island (ASC)
        /// </summary>
        public static GdCountryIso3Code AscensionIsland => new(Iso3Codes.ASC);

        /// <summary>
        /// Andorra (AND)
        /// </summary>
        public static GdCountryIso3Code Andorra => new(Iso3Codes.AND);

        /// <summary>
        /// United Arab Emirates (ARE)
        /// </summary>
        public static GdCountryIso3Code UnitedArabEmirates => new(Iso3Codes.ARE);

        /// <summary>
        /// Afghanistan (AFG)
        /// </summary>
        public static GdCountryIso3Code Afghanistan => new(Iso3Codes.AFG);

        /// <summary>
        /// Antigua And Barbuda (ATG)
        /// </summary>
        public static GdCountryIso3Code AntiguaAndBarbuda => new(Iso3Codes.ATG);

        /// <summary>
        /// Anguilla (AIA)
        /// </summary>
        public static GdCountryIso3Code Anguilla => new(Iso3Codes.AIA);

        /// <summary>
        /// Albania (ALB)
        /// </summary>
        public static GdCountryIso3Code Albania => new(Iso3Codes.ALB);

        /// <summary>
        /// Armenia (ARM)
        /// </summary>
        public static GdCountryIso3Code Armenia => new(Iso3Codes.ARM);

        /// <summary>
        /// Netherlands Antilles (ANT)
        /// </summary>
        public static GdCountryIso3Code NetherlandsAntilles => new(Iso3Codes.ANT);

        /// <summary>
        /// Angola (AGO)
        /// </summary>
        public static GdCountryIso3Code Angola => new(Iso3Codes.AGO);

        /// <summary>
        /// Antarctica (ATA)
        /// </summary>
        public static GdCountryIso3Code Antarctica => new(Iso3Codes.ATA);

        /// <summary>
        /// Argentina (ARG)
        /// </summary>
        public static GdCountryIso3Code Argentina => new(Iso3Codes.ARG);

        /// <summary>
        /// American Samoa (ASM)
        /// </summary>
        public static GdCountryIso3Code AmericanSamoa => new(Iso3Codes.ASM);

        /// <summary>
        /// Austria (AUT)
        /// </summary>
        public static GdCountryIso3Code Austria => new(Iso3Codes.AUT);

        /// <summary>
        /// Australia (AUS)
        /// </summary>
        public static GdCountryIso3Code Australia => new(Iso3Codes.AUS);

        /// <summary>
        /// Aruba (ABW)
        /// </summary>
        public static GdCountryIso3Code Aruba => new(Iso3Codes.ABW);

        /// <summary>
        /// Aland Islands (ALA)
        /// </summary>
        public static GdCountryIso3Code AlandIslands => new(Iso3Codes.ALA);

        /// <summary>
        /// Azerbaijan (AZE)
        /// </summary>
        public static GdCountryIso3Code Azerbaijan => new(Iso3Codes.AZE);

        /// <summary>
        /// Bosnia And Herzegovina (BIH)
        /// </summary>
        public static GdCountryIso3Code BosniaAndHerzegovina => new(Iso3Codes.BIH);

        /// <summary>
        /// Barbados (BRB)
        /// </summary>
        public static GdCountryIso3Code Barbados => new(Iso3Codes.BRB);

        /// <summary>
        /// Bangladesh (BGD)
        /// </summary>
        public static GdCountryIso3Code Bangladesh => new(Iso3Codes.BGD);

        /// <summary>
        /// Belgium (BEL)
        /// </summary>
        public static GdCountryIso3Code Belgium => new(Iso3Codes.BEL);

        /// <summary>
        /// Burkina Faso (BFA)
        /// </summary>
        public static GdCountryIso3Code BurkinaFaso => new(Iso3Codes.BFA);

        /// <summary>
        /// Bulgaria (BGR)
        /// </summary>
        public static GdCountryIso3Code Bulgaria => new(Iso3Codes.BGR);

        /// <summary>
        /// Bahrain (BHR)
        /// </summary>
        public static GdCountryIso3Code Bahrain => new(Iso3Codes.BHR);

        /// <summary>
        /// Burundi (BDI)
        /// </summary>
        public static GdCountryIso3Code Burundi => new(Iso3Codes.BDI);

        /// <summary>
        /// Benin (BEN)
        /// </summary>
        public static GdCountryIso3Code Benin => new(Iso3Codes.BEN);

        /// <summary>
        /// Bermuda (BMU)
        /// </summary>
        public static GdCountryIso3Code Bermuda => new(Iso3Codes.BMU);

        /// <summary>
        /// Brunei Darussalam (BRN)
        /// </summary>
        public static GdCountryIso3Code BruneiDarussalam => new(Iso3Codes.BRN);

        /// <summary>
        /// Bolivia (BOL)
        /// </summary>
        public static GdCountryIso3Code Bolivia => new(Iso3Codes.BOL);

        /// <summary>
        /// Brazil (BRA)
        /// </summary>
        public static GdCountryIso3Code Brazil => new(Iso3Codes.BRA);

        /// <summary>
        /// Bahamas (BHS)
        /// </summary>
        public static GdCountryIso3Code Bahamas => new(Iso3Codes.BHS);

        /// <summary>
        /// Bhutan (BTN)
        /// </summary>
        public static GdCountryIso3Code Bhutan => new(Iso3Codes.BTN);

        /// <summary>
        /// Botswana (BWA)
        /// </summary>
        public static GdCountryIso3Code Botswana => new(Iso3Codes.BWA);

        /// <summary>
        /// Belarus (BLR)
        /// </summary>
        public static GdCountryIso3Code Belarus => new(Iso3Codes.BLR);

        /// <summary>
        /// Belize (BLZ)
        /// </summary>
        public static GdCountryIso3Code Belize => new(Iso3Codes.BLZ);

        /// <summary>
        /// Canada (CAN)
        /// </summary>
        public static GdCountryIso3Code Canada => new(Iso3Codes.CAN);

        /// <summary>
        /// Cocos (Keeling) Islands (CCK)
        /// </summary>
        public static GdCountryIso3Code CocosKeelingIslands => new(Iso3Codes.CCK);

        /// <summary>
        /// Congo, Democratic Republic of the (COD)
        /// </summary>
        public static GdCountryIso3Code CongoDemocraticRepublicOfThe => new(Iso3Codes.COD);

        /// <summary>
        /// Central African Republic (CAF)
        /// </summary>
        public static GdCountryIso3Code CentralAfricanRepublic => new(Iso3Codes.CAF);

        /// <summary>
        /// Congo, Republic of the (COG)
        /// </summary>
        public static GdCountryIso3Code CongoRepublicOfThe => new(Iso3Codes.COG);

        /// <summary>
        /// Switzerland (CHE)
        /// </summary>
        public static GdCountryIso3Code Switzerland => new(Iso3Codes.CHE);

        /// <summary>
        /// Ivory Coast (CIV)
        /// </summary>
        public static GdCountryIso3Code IvoryCoast => new(Iso3Codes.CIV);

        /// <summary>
        /// Cook Islands (COK)
        /// </summary>
        public static GdCountryIso3Code CookIslands => new(Iso3Codes.COK);

        /// <summary>
        /// Chile (CHL)
        /// </summary>
        public static GdCountryIso3Code Chile => new(Iso3Codes.CHL);

        /// <summary>
        /// Cameroon (CMR)
        /// </summary>
        public static GdCountryIso3Code Cameroon => new(Iso3Codes.CMR);

        /// <summary>
        /// China (CHN)
        /// </summary>
        public static GdCountryIso3Code China => new(Iso3Codes.CHN);

        /// <summary>
        /// Colombia (COL)
        /// </summary>
        public static GdCountryIso3Code Colombia => new(Iso3Codes.COL);

        /// <summary>
        /// Costa Rica (CRI)
        /// </summary>
        public static GdCountryIso3Code CostaRica => new(Iso3Codes.CRI);

        /// <summary>
        /// Cuba (CUB)
        /// </summary>
        public static GdCountryIso3Code Cuba => new(Iso3Codes.CUB);

        /// <summary>
        /// Cape Verde (CPV)
        /// </summary>
        public static GdCountryIso3Code CapeVerde => new(Iso3Codes.CPV);

        /// <summary>
        /// Christmas Island (CXR)
        /// </summary>
        public static GdCountryIso3Code ChristmasIsland => new(Iso3Codes.CXR);

        /// <summary>
        /// Cyprus (CYP)
        /// </summary>
        public static GdCountryIso3Code Cyprus => new(Iso3Codes.CYP);

        /// <summary>
        /// Czech Republic (CZE)
        /// </summary>
        public static GdCountryIso3Code CzechRepublic => new(Iso3Codes.CZE);

        /// <summary>
        /// Germany (DEU)
        /// </summary>
        public static GdCountryIso3Code Germany => new(Iso3Codes.DEU);

        /// <summary>
        /// Djibouti (DJI)
        /// </summary>
        public static GdCountryIso3Code Djibouti => new(Iso3Codes.DJI);

        /// <summary>
        /// Denmark (DNK)
        /// </summary>
        public static GdCountryIso3Code Denmark => new(Iso3Codes.DNK);

        /// <summary>
        /// Dominica (DMA)
        /// </summary>
        public static GdCountryIso3Code Dominica => new(Iso3Codes.DMA);

        /// <summary>
        /// Dominican Republic (DOM)
        /// </summary>
        public static GdCountryIso3Code DominicanRepublic => new(Iso3Codes.DOM);

        /// <summary>
        /// Algeria (DZA)
        /// </summary>
        public static GdCountryIso3Code Algeria => new(Iso3Codes.DZA);

        /// <summary>
        /// Ecuador (ECU)
        /// </summary>
        public static GdCountryIso3Code Ecuador => new(Iso3Codes.ECU);

        /// <summary>
        /// Estonia (EST)
        /// </summary>
        public static GdCountryIso3Code Estonia => new(Iso3Codes.EST);

        /// <summary>
        /// Egypt (EGY)
        /// </summary>
        public static GdCountryIso3Code Egypt => new(Iso3Codes.EGY);

        /// <summary>
        /// Western Sahara (ESH)
        /// </summary>
        public static GdCountryIso3Code WesternSahara => new(Iso3Codes.ESH);

        /// <summary>
        /// Eritrea (ERI)
        /// </summary>
        public static GdCountryIso3Code Eritrea => new(Iso3Codes.ERI);

        /// <summary>
        /// Spain (ESP)
        /// </summary>
        public static GdCountryIso3Code Spain => new(Iso3Codes.ESP);

        /// <summary>
        /// Ethiopia (ETH)
        /// </summary>
        public static GdCountryIso3Code Ethiopia => new(Iso3Codes.ETH);

        /// <summary>
        /// Finland (FIN)
        /// </summary>
        public static GdCountryIso3Code Finland => new(Iso3Codes.FIN);

        /// <summary>
        /// Fiji (FJI)
        /// </summary>
        public static GdCountryIso3Code Fiji => new(Iso3Codes.FJI);

        /// <summary>
        /// Falkland Islands (FLK)
        /// </summary>
        public static GdCountryIso3Code FalklandIslands => new(Iso3Codes.FLK);

        /// <summary>
        /// Micronesia (FSM)
        /// </summary>
        public static GdCountryIso3Code Micronesia => new(Iso3Codes.FSM);

        /// <summary>
        /// Faroe Islands (FRO)
        /// </summary>
        public static GdCountryIso3Code FaroeIslands => new(Iso3Codes.FRO);

        /// <summary>
        /// France (FRA)
        /// </summary>
        public static GdCountryIso3Code France => new(Iso3Codes.FRA);

        /// <summary>
        /// Gabon (GAB)
        /// </summary>
        public static GdCountryIso3Code Gabon => new(Iso3Codes.GAB);

        /// <summary>
        /// United Kingdom (GBR)
        /// </summary>
        public static GdCountryIso3Code UnitedKingdom => new(Iso3Codes.GBR);

        /// <summary>
        /// Grenada (GRD)
        /// </summary>
        public static GdCountryIso3Code Grenada => new(Iso3Codes.GRD);

        /// <summary>
        /// Georgia (GEO)
        /// </summary>
        public static GdCountryIso3Code Georgia => new(Iso3Codes.GEO);

        /// <summary>
        /// French Guiana (GUF)
        /// </summary>
        public static GdCountryIso3Code FrenchGuiana => new(Iso3Codes.GUF);

        /// <summary>
        /// Guernsey (GGY)
        /// </summary>
        public static GdCountryIso3Code Guernsey => new(Iso3Codes.GGY);

        /// <summary>
        /// Ghana (GHA)
        /// </summary>
        public static GdCountryIso3Code Ghana => new(Iso3Codes.GHA);

        /// <summary>
        /// Gibraltar (GIB)
        /// </summary>
        public static GdCountryIso3Code Gibraltar => new(Iso3Codes.GIB);

        /// <summary>
        /// Greenland (GRL)
        /// </summary>
        public static GdCountryIso3Code Greenland => new(Iso3Codes.GRL);

        /// <summary>
        /// Gambia (GMB)
        /// </summary>
        public static GdCountryIso3Code Gambia => new(Iso3Codes.GMB);

        /// <summary>
        /// Guinea, Republic of (GIN)
        /// </summary>
        public static GdCountryIso3Code GuineaRepublicOf => new(Iso3Codes.GIN);

        /// <summary>
        /// Global System (GMS)
        /// </summary>
        public static GdCountryIso3Code GlobalSystem => new(Iso3Codes.GMS);

        /// <summary>
        /// Guadeloupe (GLP)
        /// </summary>
        public static GdCountryIso3Code Guadeloupe => new(Iso3Codes.GLP);

        /// <summary>
        /// Equatorial Guinea (GNQ)
        /// </summary>
        public static GdCountryIso3Code EquatorialGuinea => new(Iso3Codes.GNQ);

        /// <summary>
        /// Greece (GRC)
        /// </summary>
        public static GdCountryIso3Code Greece => new(Iso3Codes.GRC);

        /// <summary>
        /// South Georgia (SGS)
        /// </summary>
        public static GdCountryIso3Code SouthGeorgia => new(Iso3Codes.SGS);

        /// <summary>
        /// Guatemala (GTM)
        /// </summary>
        public static GdCountryIso3Code Guatemala => new(Iso3Codes.GTM);

        /// <summary>
        /// Guam (GUM)
        /// </summary>
        public static GdCountryIso3Code Guam => new(Iso3Codes.GUM);

        /// <summary>
        /// Guinea-Bissau (GNB)
        /// </summary>
        public static GdCountryIso3Code GuineaBissau => new(Iso3Codes.GNB);

        /// <summary>
        /// Guyana (GUY)
        /// </summary>
        public static GdCountryIso3Code Guyana => new(Iso3Codes.GUY);

        /// <summary>
        /// Hong Kong (HKG)
        /// </summary>
        public static GdCountryIso3Code HongKong => new(Iso3Codes.HKG);

        /// <summary>
        /// Honduras (HND)
        /// </summary>
        public static GdCountryIso3Code Honduras => new(Iso3Codes.HND);

        /// <summary>
        /// Croatia (HRV)
        /// </summary>
        public static GdCountryIso3Code Croatia => new(Iso3Codes.HRV);

        /// <summary>
        /// Haiti (HTI)
        /// </summary>
        public static GdCountryIso3Code Haiti => new(Iso3Codes.HTI);

        /// <summary>
        /// Hungary (HUN)
        /// </summary>
        public static GdCountryIso3Code Hungary => new(Iso3Codes.HUN);

        /// <summary>
        /// Indonesia (IDN)
        /// </summary>
        public static GdCountryIso3Code Indonesia => new(Iso3Codes.IDN);

        /// <summary>
        /// Ireland (IRL)
        /// </summary>
        public static GdCountryIso3Code Ireland => new(Iso3Codes.IRL);

        /// <summary>
        /// Israel (ISR)
        /// </summary>
        public static GdCountryIso3Code Israel => new(Iso3Codes.ISR);

        /// <summary>
        /// Isle of Man (IMN)
        /// </summary>
        public static GdCountryIso3Code IsleOfMan => new(Iso3Codes.IMN);

        /// <summary>
        /// India (IND)
        /// </summary>
        public static GdCountryIso3Code India => new(Iso3Codes.IND);

        /// <summary>
        /// British Indian Ocean Territory (IOT)
        /// </summary>
        public static GdCountryIso3Code BritishIndianOceanTerritory => new(Iso3Codes.IOT);

        /// <summary>
        /// Iraq (IRQ)
        /// </summary>
        public static GdCountryIso3Code Iraq => new(Iso3Codes.IRQ);

        /// <summary>
        /// Iran (IRN)
        /// </summary>
        public static GdCountryIso3Code Iran => new(Iso3Codes.IRN);

        /// <summary>
        /// Iceland (ISL)
        /// </summary>
        public static GdCountryIso3Code Iceland => new(Iso3Codes.ISL);

        /// <summary>
        /// Italy (ITA)
        /// </summary>
        public static GdCountryIso3Code Italy => new(Iso3Codes.ITA);

        /// <summary>
        /// Jersey (JEY)
        /// </summary>
        public static GdCountryIso3Code Jersey => new(Iso3Codes.JEY);

        /// <summary>
        /// Jamaica (JAM)
        /// </summary>
        public static GdCountryIso3Code Jamaica => new(Iso3Codes.JAM);

        /// <summary>
        /// Jordan (JOR)
        /// </summary>
        public static GdCountryIso3Code Jordan => new(Iso3Codes.JOR);

        /// <summary>
        /// Japan (JPN)
        /// </summary>
        public static GdCountryIso3Code Japan => new(Iso3Codes.JPN);

        /// <summary>
        /// Kenya (KEN)
        /// </summary>
        public static GdCountryIso3Code Kenya => new(Iso3Codes.KEN);

        /// <summary>
        /// Kyrgyzstan (KGZ)
        /// </summary>
        public static GdCountryIso3Code Kyrgyzstan => new(Iso3Codes.KGZ);

        /// <summary>
        /// Cambodia (KHM)
        /// </summary>
        public static GdCountryIso3Code Cambodia => new(Iso3Codes.KHM);

        /// <summary>
        /// Kiribati (KIR)
        /// </summary>
        public static GdCountryIso3Code Kiribati => new(Iso3Codes.KIR);

        /// <summary>
        /// Comoros (COM)
        /// </summary>
        public static GdCountryIso3Code Comoros => new(Iso3Codes.COM);

        /// <summary>
        /// Saint Kitts And Nevis (KNA)
        /// </summary>
        public static GdCountryIso3Code SaintKittsAndNevis => new(Iso3Codes.KNA);

        /// <summary>
        /// Korea, North (PRK)
        /// </summary>
        public static GdCountryIso3Code KoreaNorth => new(Iso3Codes.PRK);

        /// <summary>
        /// Korea, South (KOR)
        /// </summary>
        public static GdCountryIso3Code KoreaSouth => new(Iso3Codes.KOR);

        /// <summary>
        /// Kuwait (KWT)
        /// </summary>
        public static GdCountryIso3Code Kuwait => new(Iso3Codes.KWT);

        /// <summary>
        /// Cayman Islands (CYM)
        /// </summary>
        public static GdCountryIso3Code CaymanIslands => new(Iso3Codes.CYM);

        /// <summary>
        /// Kazakhstan (KAZ)
        /// </summary>
        public static GdCountryIso3Code Kazakhstan => new(Iso3Codes.KAZ);

        /// <summary>
        /// Laos (LAO)
        /// </summary>
        public static GdCountryIso3Code Laos => new(Iso3Codes.LAO);

        /// <summary>
        /// Lebanon (LBN)
        /// </summary>
        public static GdCountryIso3Code Lebanon => new(Iso3Codes.LBN);

        /// <summary>
        /// Saint Lucia (LCA)
        /// </summary>
        public static GdCountryIso3Code SaintLucia => new(Iso3Codes.LCA);

        /// <summary>
        /// Liechtenstein (LIE)
        /// </summary>
        public static GdCountryIso3Code Liechtenstein => new(Iso3Codes.LIE);

        /// <summary>
        /// Sri Lanka (LKA)
        /// </summary>
        public static GdCountryIso3Code SriLanka => new(Iso3Codes.LKA);

        /// <summary>
        /// Liberia (LBR)
        /// </summary>
        public static GdCountryIso3Code Liberia => new(Iso3Codes.LBR);

        /// <summary>
        /// Lesotho (LSO)
        /// </summary>
        public static GdCountryIso3Code Lesotho => new(Iso3Codes.LSO);

        /// <summary>
        /// Lithuania (LTU)
        /// </summary>
        public static GdCountryIso3Code Lithuania => new(Iso3Codes.LTU);

        /// <summary>
        /// Luxembourg (LUX)
        /// </summary>
        public static GdCountryIso3Code Luxembourg => new(Iso3Codes.LUX);

        /// <summary>
        /// Latvia (LVA)
        /// </summary>
        public static GdCountryIso3Code Latvia => new(Iso3Codes.LVA);

        /// <summary>
        /// Libya (LBY)
        /// </summary>
        public static GdCountryIso3Code Libya => new(Iso3Codes.LBY);

        /// <summary>
        /// Morocco (MAR)
        /// </summary>
        public static GdCountryIso3Code Morocco => new(Iso3Codes.MAR);

        /// <summary>
        /// Monaco (MCO)
        /// </summary>
        public static GdCountryIso3Code Monaco => new(Iso3Codes.MCO);

        /// <summary>
        /// Moldova (MDA)
        /// </summary>
        public static GdCountryIso3Code Moldova => new(Iso3Codes.MDA);

        /// <summary>
        /// Montenegro (MNE)
        /// </summary>
        public static GdCountryIso3Code Montenegro => new(Iso3Codes.MNE);

        /// <summary>
        /// Madagascar (MDG)
        /// </summary>
        public static GdCountryIso3Code Madagascar => new(Iso3Codes.MDG);

        /// <summary>
        /// Marshall islands (MHL)
        /// </summary>
        public static GdCountryIso3Code MarshallIslands => new(Iso3Codes.MHL);

        /// <summary>
        /// Macedonia (MKD)
        /// </summary>
        public static GdCountryIso3Code Macedonia => new(Iso3Codes.MKD);

        /// <summary>
        /// Mali (MLI)
        /// </summary>
        public static GdCountryIso3Code Mali => new(Iso3Codes.MLI);

        /// <summary>
        /// Myanmar (MMR)
        /// </summary>
        public static GdCountryIso3Code Myanmar => new(Iso3Codes.MMR);

        /// <summary>
        /// Mongolia (MNG)
        /// </summary>
        public static GdCountryIso3Code Mongolia => new(Iso3Codes.MNG);

        /// <summary>
        /// Macau (MAC)
        /// </summary>
        public static GdCountryIso3Code Macau => new(Iso3Codes.MAC);

        /// <summary>
        /// Northern Mariana Islands (MNP)
        /// </summary>
        public static GdCountryIso3Code NorthernMarianaIslands => new(Iso3Codes.MNP);

        /// <summary>
        /// Martinique (MTQ)
        /// </summary>
        public static GdCountryIso3Code Martinique => new(Iso3Codes.MTQ);

        /// <summary>
        /// Mauritania (MRT)
        /// </summary>
        public static GdCountryIso3Code Mauritania => new(Iso3Codes.MRT);

        /// <summary>
        /// Montserrat (MSR)
        /// </summary>
        public static GdCountryIso3Code Montserrat => new(Iso3Codes.MSR);

        /// <summary>
        /// Malta (MLT)
        /// </summary>
        public static GdCountryIso3Code Malta => new(Iso3Codes.MLT);

        /// <summary>
        /// Mauritius (MUS)
        /// </summary>
        public static GdCountryIso3Code Mauritius => new(Iso3Codes.MUS);

        /// <summary>
        /// Maldives (MDV)
        /// </summary>
        public static GdCountryIso3Code Maldives => new(Iso3Codes.MDV);

        /// <summary>
        /// Malawi (MWI)
        /// </summary>
        public static GdCountryIso3Code Malawi => new(Iso3Codes.MWI);

        /// <summary>
        /// Mexico (MEX)
        /// </summary>
        public static GdCountryIso3Code Mexico => new(Iso3Codes.MEX);

        /// <summary>
        /// Malaysia (MYS)
        /// </summary>
        public static GdCountryIso3Code Malaysia => new(Iso3Codes.MYS);

        /// <summary>
        /// Mozambique (MOZ)
        /// </summary>
        public static GdCountryIso3Code Mozambique => new(Iso3Codes.MOZ);

        /// <summary>
        /// Namibia (NAM)
        /// </summary>
        public static GdCountryIso3Code Namibia => new(Iso3Codes.NAM);

        /// <summary>
        /// New Caledonia (NCL)
        /// </summary>
        public static GdCountryIso3Code NewCaledonia => new(Iso3Codes.NCL);

        /// <summary>
        /// Niger (NER)
        /// </summary>
        public static GdCountryIso3Code Niger => new(Iso3Codes.NER);

        /// <summary>
        /// Norfolk Island (NFK)
        /// </summary>
        public static GdCountryIso3Code NorfolkIsland => new(Iso3Codes.NFK);

        /// <summary>
        /// Nigeria (NGA)
        /// </summary>
        public static GdCountryIso3Code Nigeria => new(Iso3Codes.NGA);

        /// <summary>
        /// Nicaragua (NIC)
        /// </summary>
        public static GdCountryIso3Code Nicaragua => new(Iso3Codes.NIC);

        /// <summary>
        /// Netherlands, The (NLD)
        /// </summary>
        public static GdCountryIso3Code NetherlandsThe => new(Iso3Codes.NLD);

        /// <summary>
        /// Norway (NOR)
        /// </summary>
        public static GdCountryIso3Code Norway => new(Iso3Codes.NOR);

        /// <summary>
        /// Nepal (NPL)
        /// </summary>
        public static GdCountryIso3Code Nepal => new(Iso3Codes.NPL);

        /// <summary>
        /// Nauru (NRU)
        /// </summary>
        public static GdCountryIso3Code Nauru => new(Iso3Codes.NRU);

        /// <summary>
        /// Niue (NIU)
        /// </summary>
        public static GdCountryIso3Code Niue => new(Iso3Codes.NIU);

        /// <summary>
        /// New Zealand (NZL)
        /// </summary>
        public static GdCountryIso3Code NewZealand => new(Iso3Codes.NZL);

        /// <summary>
        /// Oman (OMN)
        /// </summary>
        public static GdCountryIso3Code Oman => new(Iso3Codes.OMN);

        /// <summary>
        /// Panama (PAN)
        /// </summary>
        public static GdCountryIso3Code Panama => new(Iso3Codes.PAN);

        /// <summary>
        /// Peru (PER)
        /// </summary>
        public static GdCountryIso3Code Peru => new(Iso3Codes.PER);

        /// <summary>
        /// French Polynesia (PYF)
        /// </summary>
        public static GdCountryIso3Code FrenchPolynesia => new(Iso3Codes.PYF);

        /// <summary>
        /// Papua New Guinea (PNG)
        /// </summary>
        public static GdCountryIso3Code PapuaNewGuinea => new(Iso3Codes.PNG);

        /// <summary>
        /// Philippines (PHL)
        /// </summary>
        public static GdCountryIso3Code Philippines => new(Iso3Codes.PHL);

        /// <summary>
        /// Pakistan (PAK)
        /// </summary>
        public static GdCountryIso3Code Pakistan => new(Iso3Codes.PAK);

        /// <summary>
        /// Poland (POL)
        /// </summary>
        public static GdCountryIso3Code Poland => new(Iso3Codes.POL);

        /// <summary>
        /// Saint Pierre and Miquelon (SPM)
        /// </summary>
        public static GdCountryIso3Code SaintPierreAndMiquelon => new(Iso3Codes.SPM);

        /// <summary>
        /// Pitcairn Islands (PCN)
        /// </summary>
        public static GdCountryIso3Code PitcairnIslands => new(Iso3Codes.PCN);

        /// <summary>
        /// Puerto Rico (PRI)
        /// </summary>
        public static GdCountryIso3Code PuertoRico => new(Iso3Codes.PRI);

        /// <summary>
        /// Palestine (PSE)
        /// </summary>
        public static GdCountryIso3Code Palestine => new(Iso3Codes.PSE);

        /// <summary>
        /// Portugal (PRT)
        /// </summary>
        public static GdCountryIso3Code Portugal => new(Iso3Codes.PRT);

        /// <summary>
        /// Palau (PLW)
        /// </summary>
        public static GdCountryIso3Code Palau => new(Iso3Codes.PLW);

        /// <summary>
        /// Paraguay (PRY)
        /// </summary>
        public static GdCountryIso3Code Paraguay => new(Iso3Codes.PRY);

        /// <summary>
        /// Qatar (QAT)
        /// </summary>
        public static GdCountryIso3Code Qatar => new(Iso3Codes.QAT);

        /// <summary>
        /// Reunion (REU)
        /// </summary>
        public static GdCountryIso3Code Reunion => new(Iso3Codes.REU);

        /// <summary>
        /// Romania (ROU)
        /// </summary>
        public static GdCountryIso3Code Romania => new(Iso3Codes.ROU);

        /// <summary>
        /// Serbia (SRB)
        /// </summary>
        public static GdCountryIso3Code Serbia => new(Iso3Codes.SRB);

        /// <summary>
        /// Russia (RUS)
        /// </summary>
        public static GdCountryIso3Code Russia => new(Iso3Codes.RUS);

        /// <summary>
        /// Rwanda (RWA)
        /// </summary>
        public static GdCountryIso3Code Rwanda => new(Iso3Codes.RWA);

        /// <summary>
        /// Saudi Arabia (SAU)
        /// </summary>
        public static GdCountryIso3Code SaudiArabia => new(Iso3Codes.SAU);

        /// <summary>
        /// Solomon Islands (SLB)
        /// </summary>
        public static GdCountryIso3Code SolomonIslands => new(Iso3Codes.SLB);

        /// <summary>
        /// Seychelles (SYC)
        /// </summary>
        public static GdCountryIso3Code Seychelles => new(Iso3Codes.SYC);

        /// <summary>
        /// Sudan (SDN)
        /// </summary>
        public static GdCountryIso3Code Sudan => new(Iso3Codes.SDN);

        /// <summary>
        /// Sweden (SWE)
        /// </summary>
        public static GdCountryIso3Code Sweden => new(Iso3Codes.SWE);

        /// <summary>
        /// Singapore (SGP)
        /// </summary>
        public static GdCountryIso3Code Singapore => new(Iso3Codes.SGP);

        /// <summary>
        /// Saint Helena (SHN)
        /// </summary>
        public static GdCountryIso3Code SaintHelena => new(Iso3Codes.SHN);

        /// <summary>
        /// Slovenia (SVN)
        /// </summary>
        public static GdCountryIso3Code Slovenia => new(Iso3Codes.SVN);

        /// <summary>
        /// Slovakia (SVK)
        /// </summary>
        public static GdCountryIso3Code Slovakia => new(Iso3Codes.SVK);

        /// <summary>
        /// Sierra Leone (SLE)
        /// </summary>
        public static GdCountryIso3Code SierraLeone => new(Iso3Codes.SLE);

        /// <summary>
        /// San Marino (SMR)
        /// </summary>
        public static GdCountryIso3Code SanMarino => new(Iso3Codes.SMR);

        /// <summary>
        /// Senegal (SEN)
        /// </summary>
        public static GdCountryIso3Code Senegal => new(Iso3Codes.SEN);

        /// <summary>
        /// Somalia (SOM)
        /// </summary>
        public static GdCountryIso3Code Somalia => new(Iso3Codes.SOM);

        /// <summary>
        /// Suriname (SUR)
        /// </summary>
        public static GdCountryIso3Code Suriname => new(Iso3Codes.SUR);

        /// <summary>
        /// South Sudan (SSD)
        /// </summary>
        public static GdCountryIso3Code SouthSudan => new(Iso3Codes.SSD);

        /// <summary>
        /// Sao Tome and Principe (STP)
        /// </summary>
        public static GdCountryIso3Code SaoTomeAndPrincipe => new(Iso3Codes.STP);

        /// <summary>
        /// El Salvador (SLV)
        /// </summary>
        public static GdCountryIso3Code ElSalvador => new(Iso3Codes.SLV);

        /// <summary>
        /// Sint Maarten (SXM)
        /// </summary>
        public static GdCountryIso3Code SintMaarten => new(Iso3Codes.SXM);

        /// <summary>
        /// Syria (SYR)
        /// </summary>
        public static GdCountryIso3Code Syria => new(Iso3Codes.SYR);

        /// <summary>
        /// Swaziland (SWZ)
        /// </summary>
        public static GdCountryIso3Code Swaziland => new(Iso3Codes.SWZ);

        /// <summary>
        /// Tristan da Cunha (TAA)
        /// </summary>
        public static GdCountryIso3Code TristanDaCunha => new(Iso3Codes.TAA);

        /// <summary>
        /// Turks And Caicos Islands (TCA)
        /// </summary>
        public static GdCountryIso3Code TurksAndCaicosIslands => new(Iso3Codes.TCA);

        /// <summary>
        /// Chad (TCD)
        /// </summary>
        public static GdCountryIso3Code Chad => new(Iso3Codes.TCD);

        /// <summary>
        /// Togo (TGO)
        /// </summary>
        public static GdCountryIso3Code Togo => new(Iso3Codes.TGO);

        /// <summary>
        /// Thailand (THA)
        /// </summary>
        public static GdCountryIso3Code Thailand => new(Iso3Codes.THA);

        /// <summary>
        /// Tajikistan (TJK)
        /// </summary>
        public static GdCountryIso3Code Tajikistan => new(Iso3Codes.TJK);

        /// <summary>
        /// Tokelau (TKL)
        /// </summary>
        public static GdCountryIso3Code Tokelau => new(Iso3Codes.TKL);

        /// <summary>
        /// East Timor (TMP)
        /// </summary>
        public static GdCountryIso3Code EastTimor => new(Iso3Codes.TMP);

        /// <summary>
        /// Turkmenistan (TKM)
        /// </summary>
        public static GdCountryIso3Code Turkmenistan => new(Iso3Codes.TKM);

        /// <summary>
        /// Tunisia (TUN)
        /// </summary>
        public static GdCountryIso3Code Tunisia => new(Iso3Codes.TUN);

        /// <summary>
        /// Tonga (TON)
        /// </summary>
        public static GdCountryIso3Code Tonga => new(Iso3Codes.TON);

        /// <summary>
        /// Turkey (TUR)
        /// </summary>
        public static GdCountryIso3Code Turkey => new(Iso3Codes.TUR);

        /// <summary>
        /// Trinidad And Tobago (TTO)
        /// </summary>
        public static GdCountryIso3Code TrinidadAndTobago => new(Iso3Codes.TTO);

        /// <summary>
        /// Tuvalu (TUV)
        /// </summary>
        public static GdCountryIso3Code Tuvalu => new(Iso3Codes.TUV);

        /// <summary>
        /// Taiwan (TWN)
        /// </summary>
        public static GdCountryIso3Code Taiwan => new(Iso3Codes.TWN);

        /// <summary>
        /// Tanzania (TZA)
        /// </summary>
        public static GdCountryIso3Code Tanzania => new(Iso3Codes.TZA);

        /// <summary>
        /// Ukraine (UKR)
        /// </summary>
        public static GdCountryIso3Code Ukraine => new(Iso3Codes.UKR);

        /// <summary>
        /// Uganda (UGA)
        /// </summary>
        public static GdCountryIso3Code Uganda => new(Iso3Codes.UGA);

        /// <summary>
        /// United States (USA)
        /// </summary>
        public static GdCountryIso3Code UnitedStates => new(Iso3Codes.USA);

        /// <summary>
        /// Uruguay (URY)
        /// </summary>
        public static GdCountryIso3Code Uruguay => new(Iso3Codes.URY);

        /// <summary>
        /// Uzbekistan (UZB)
        /// </summary>
        public static GdCountryIso3Code Uzbekistan => new(Iso3Codes.UZB);

        /// <summary>
        /// Vatican City (VAT)
        /// </summary>
        public static GdCountryIso3Code VaticanCity => new(Iso3Codes.VAT);

        /// <summary>
        /// Saint Vincent and the Grenadines (VCT)
        /// </summary>
        public static GdCountryIso3Code SaintVincentAndTheGrenadines => new(Iso3Codes.VCT);

        /// <summary>
        /// Venezuela (VEN)
        /// </summary>
        public static GdCountryIso3Code Venezuela => new(Iso3Codes.VEN);

        /// <summary>
        /// British Virgin Islands (VGB)
        /// </summary>
        public static GdCountryIso3Code BritishVirginIslands => new(Iso3Codes.VGB);

        /// <summary>
        /// US Virgin Islands (VIR)
        /// </summary>
        public static GdCountryIso3Code UsVirginIslands => new(Iso3Codes.VIR);

        /// <summary>
        /// Vietnam (VNM)
        /// </summary>
        public static GdCountryIso3Code Vietnam => new(Iso3Codes.VNM);

        /// <summary>
        /// Vanuatu (VUT)
        /// </summary>
        public static GdCountryIso3Code Vanuatu => new(Iso3Codes.VUT);

        /// <summary>
        /// Wallis And Futuna (WLF)
        /// </summary>
        public static GdCountryIso3Code WallisAndFutuna => new(Iso3Codes.WLF);

        /// <summary>
        /// Samoa (WSM)
        /// </summary>
        public static GdCountryIso3Code Samoa => new(Iso3Codes.WSM);

        /// <summary>
        /// Kosovo (UNK)
        /// </summary>
        public static GdCountryIso3Code Kosovo => new(Iso3Codes.UNK);

        /// <summary>
        /// Inmarsat (XNM)
        /// </summary>
        public static GdCountryIso3Code Inmarsat => new(Iso3Codes.XNM);

        /// <summary>
        /// Yemen (YEM)
        /// </summary>
        public static GdCountryIso3Code Yemen => new(Iso3Codes.YEM);

        /// <summary>
        /// Mayotte (MYT)
        /// </summary>
        public static GdCountryIso3Code Mayotte => new(Iso3Codes.MYT);

        /// <summary>
        /// South Africa (ZAF)
        /// </summary>
        public static GdCountryIso3Code SouthAfrica => new(Iso3Codes.ZAF);

        /// <summary>
        /// Zambia (ZMB)
        /// </summary>
        public static GdCountryIso3Code Zambia => new(Iso3Codes.ZMB);

        /// <summary>
        /// Zimbabwe (ZWE)
        /// </summary>
        public static GdCountryIso3Code Zimbabwe => new(Iso3Codes.ZWE);


        #endregion
    }
}