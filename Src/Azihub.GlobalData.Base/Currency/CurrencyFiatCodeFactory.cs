namespace Azihub.GlobalData.Base.Currency
{
    public class CurrencyFiatCodeFactory
    {
        #region List
        /*
        SELECT CONCAT('/// <summary>', CHARACTER(13),
              '/// ',REGEXP_REPLACE(cur.name, '\\([A-Z]{3}\\)',''), CHARACTER(13),
              '/// </summary>', CHARACTER(13),
              'public static CurrencyFiatCode ', REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(cur.name,'.',''), '&', '_And_'), ',', '') , ' ', '_') , '(', '') , ')', '') , '-', '_'), ' => CurrencyFiatCode.FromString(Iso3FiatCodes.',`code`,');', CHARACTER(13), CHARACTER(13))
        FROM gd_currencies cur
        ORDER BY `code`		  		 
        */
        /// <summary>
        /// Abkhazian Apsar
        /// </summary>
        public static CurrencyFiatCode Abkhazian_Apsar => CurrencyFiatCode.FromString(Iso3FiatCodes.ABK);

        /// <summary>
        /// UAE Dirham 
        /// </summary>
        public static CurrencyFiatCode UAE_Dirham_AED => CurrencyFiatCode.FromString(Iso3FiatCodes.AED);

        /// <summary>
        /// Afghanistan Afghani
        /// </summary>
        public static CurrencyFiatCode Afghanistan_Afghani => CurrencyFiatCode.FromString(Iso3FiatCodes.AFN);

        /// <summary>
        /// Albanian Lek 
        /// </summary>
        public static CurrencyFiatCode Albanian_Lek_ALL => CurrencyFiatCode.FromString(Iso3FiatCodes.ALL);

        /// <summary>
        /// Armenian dram
        /// </summary>
        public static CurrencyFiatCode Armenian_dram => CurrencyFiatCode.FromString(Iso3FiatCodes.AMD);

        /// <summary>
        /// Neth Antilles Guilder 
        /// </summary>
        public static CurrencyFiatCode Neth_Antilles_Guilder_ANG => CurrencyFiatCode.FromString(Iso3FiatCodes.ANG);

        /// <summary>
        /// Angolan kwanza
        /// </summary>
        public static CurrencyFiatCode Angolan_kwanza => CurrencyFiatCode.FromString(Iso3FiatCodes.AOA);

        /// <summary>
        /// Argentine Peso 
        /// </summary>
        public static CurrencyFiatCode Argentine_Peso_ARS => CurrencyFiatCode.FromString(Iso3FiatCodes.ARS);

        /// <summary>
        /// Australian Dollar 
        /// </summary>
        public static CurrencyFiatCode Australian_Dollar_AUD => CurrencyFiatCode.FromString(Iso3FiatCodes.AUD);

        /// <summary>
        /// Aruba Florin 
        /// </summary>
        public static CurrencyFiatCode Aruba_Florin_AWG => CurrencyFiatCode.FromString(Iso3FiatCodes.AWG);

        /// <summary>
        /// Azerbaijani Manat
        /// </summary>
        public static CurrencyFiatCode Azerbaijani_Manat => CurrencyFiatCode.FromString(Iso3FiatCodes.AZN);

        /// <summary>
        /// Bosnia and Herzegovina Convert
        /// </summary>
        public static CurrencyFiatCode Bosnia_and_Herzegovina_Convert => CurrencyFiatCode.FromString(Iso3FiatCodes.BAM);

        /// <summary>
        /// Barbados Dollar 
        /// </summary>
        public static CurrencyFiatCode Barbados_Dollar_BBD => CurrencyFiatCode.FromString(Iso3FiatCodes.BBD);

        /// <summary>
        /// Bangladesh Taka 
        /// </summary>
        public static CurrencyFiatCode Bangladesh_Taka_BDT => CurrencyFiatCode.FromString(Iso3FiatCodes.BDT);

        /// <summary>
        /// Bulgarian Lev 
        /// </summary>
        public static CurrencyFiatCode Bulgarian_Lev_BGN => CurrencyFiatCode.FromString(Iso3FiatCodes.BGN);

        /// <summary>
        /// Bahraini Dinar 
        /// </summary>
        public static CurrencyFiatCode Bahraini_Dinar_BHD => CurrencyFiatCode.FromString(Iso3FiatCodes.BHD);

        /// <summary>
        /// Burundi Franc 
        /// </summary>
        public static CurrencyFiatCode Burundi_Franc_BIF => CurrencyFiatCode.FromString(Iso3FiatCodes.BIF);

        /// <summary>
        /// Bermuda Dollar 
        /// </summary>
        public static CurrencyFiatCode Bermuda_Dollar_BMD => CurrencyFiatCode.FromString(Iso3FiatCodes.BMD);

        /// <summary>
        /// Brunei Dollar 
        /// </summary>
        public static CurrencyFiatCode Brunei_Dollar_BND => CurrencyFiatCode.FromString(Iso3FiatCodes.BND);

        /// <summary>
        /// Bolivian Boliviano 
        /// </summary>
        public static CurrencyFiatCode Bolivian_Boliviano_BOB => CurrencyFiatCode.FromString(Iso3FiatCodes.BOB);

        /// <summary>
        /// Brazilian Real 
        /// </summary>
        public static CurrencyFiatCode Brazilian_Real_BRL => CurrencyFiatCode.FromString(Iso3FiatCodes.BRL);

        /// <summary>
        /// Bahamian Dollar 
        /// </summary>
        public static CurrencyFiatCode Bahamian_Dollar_BSD => CurrencyFiatCode.FromString(Iso3FiatCodes.BSD);

        /// <summary>
        /// Bhutan Ngultrum 
        /// </summary>
        public static CurrencyFiatCode Bhutan_Ngultrum_BTN => CurrencyFiatCode.FromString(Iso3FiatCodes.BTN);

        /// <summary>
        /// Botswana Pula
        /// </summary>
        public static CurrencyFiatCode Botswana_Pula => CurrencyFiatCode.FromString(Iso3FiatCodes.BWP);

        /// <summary>
        /// Belarus Ruble 
        /// </summary>
        public static CurrencyFiatCode Belarus_Ruble_BYR => CurrencyFiatCode.FromString(Iso3FiatCodes.BYR);

        /// <summary>
        /// Belize Dollar 
        /// </summary>
        public static CurrencyFiatCode Belize_Dollar_BZD => CurrencyFiatCode.FromString(Iso3FiatCodes.BZD);

        /// <summary>
        /// Canadian Dollar 
        /// </summary>
        public static CurrencyFiatCode Canadian_Dollar_CAD => CurrencyFiatCode.FromString(Iso3FiatCodes.CAD);

        /// <summary>
        /// Swiss Franc 
        /// </summary>
        public static CurrencyFiatCode Swiss_Franc_CHF => CurrencyFiatCode.FromString(Iso3FiatCodes.CHF);

        /// <summary>
        /// Chilean Peso 
        /// </summary>
        public static CurrencyFiatCode Chilean_Peso_CLP => CurrencyFiatCode.FromString(Iso3FiatCodes.CLP);

        /// <summary>
        /// Chinese Yuan 
        /// </summary>
        public static CurrencyFiatCode Chinese_Yuan_CNY => CurrencyFiatCode.FromString(Iso3FiatCodes.CNY);

        /// <summary>
        /// Colombian Peso 
        /// </summary>
        public static CurrencyFiatCode Colombian_Peso_COP => CurrencyFiatCode.FromString(Iso3FiatCodes.COP);

        /// <summary>
        /// Costa Rica Colon 
        /// </summary>
        public static CurrencyFiatCode Costa_Rica_Colon_CRC => CurrencyFiatCode.FromString(Iso3FiatCodes.CRC);

        /// <summary>
        /// Cuban Peso 
        /// </summary>
        public static CurrencyFiatCode Cuban_Peso_CUP => CurrencyFiatCode.FromString(Iso3FiatCodes.CUP);

        /// <summary>
        /// Cape Verde Escudo
        /// </summary>
        public static CurrencyFiatCode Cape_Verde_Escudo => CurrencyFiatCode.FromString(Iso3FiatCodes.CVE);

        /// <summary>
        /// Czech Koruna 
        /// </summary>
        public static CurrencyFiatCode Czech_Koruna_CZK => CurrencyFiatCode.FromString(Iso3FiatCodes.CZK);

        /// <summary>
        /// Dijibouti Franc 
        /// </summary>
        public static CurrencyFiatCode Dijibouti_Franc_DJF => CurrencyFiatCode.FromString(Iso3FiatCodes.DJF);

        /// <summary>
        /// Danish Krone 
        /// </summary>
        public static CurrencyFiatCode Danish_Krone_DKK => CurrencyFiatCode.FromString(Iso3FiatCodes.DKK);

        /// <summary>
        /// Dominican Peso 
        /// </summary>
        public static CurrencyFiatCode Dominican_Peso_DOP => CurrencyFiatCode.FromString(Iso3FiatCodes.DOP);

        /// <summary>
        /// Algerian Dinar 
        /// </summary>
        public static CurrencyFiatCode Algerian_Dinar_DZD => CurrencyFiatCode.FromString(Iso3FiatCodes.DZD);

        /// <summary>
        /// Egyptian Pound 
        /// </summary>
        public static CurrencyFiatCode Egyptian_Pound_EGP => CurrencyFiatCode.FromString(Iso3FiatCodes.EGP);

        /// <summary>
        /// Eritrean Nakfa
        /// </summary>
        public static CurrencyFiatCode Eritrean_Nakfa => CurrencyFiatCode.FromString(Iso3FiatCodes.ERN);

        /// <summary>
        /// Ethiopian Birr 
        /// </summary>
        public static CurrencyFiatCode Ethiopian_Birr_ETB => CurrencyFiatCode.FromString(Iso3FiatCodes.ETB);

        /// <summary>
        /// Euro 
        /// </summary>
        public static CurrencyFiatCode Euro_EUR => CurrencyFiatCode.FromString(Iso3FiatCodes.EUR);

        /// <summary>
        /// Fijian Dollar
        /// </summary>
        public static CurrencyFiatCode Fijian_Dollar => CurrencyFiatCode.FromString(Iso3FiatCodes.FJD);

        /// <summary>
        /// Falkland Islands Pound 
        /// </summary>
        public static CurrencyFiatCode Falkland_Islands_Pound_FKP => CurrencyFiatCode.FromString(Iso3FiatCodes.FKP);

        /// <summary>
        /// British Pound 
        /// </summary>
        public static CurrencyFiatCode British_Pound_GBP => CurrencyFiatCode.FromString(Iso3FiatCodes.GBP);

        /// <summary>
        /// Georgian Lari 
        /// </summary>
        public static CurrencyFiatCode Georgian_Lari_GEL => CurrencyFiatCode.FromString(Iso3FiatCodes.GEL);

        /// <summary>
        /// Ghanaian cedi
        /// </summary>
        public static CurrencyFiatCode Ghanaian_cedi => CurrencyFiatCode.FromString(Iso3FiatCodes.GHS);

        /// <summary>
        /// Gibraltar Pound 
        /// </summary>
        public static CurrencyFiatCode Gibraltar_Pound_GIP => CurrencyFiatCode.FromString(Iso3FiatCodes.GIP);

        /// <summary>
        /// Gambian Dalasi 
        /// </summary>
        public static CurrencyFiatCode Gambian_Dalasi_GMD => CurrencyFiatCode.FromString(Iso3FiatCodes.GMD);

        /// <summary>
        /// Guinea Franc 
        /// </summary>
        public static CurrencyFiatCode Guinea_Franc_GNF => CurrencyFiatCode.FromString(Iso3FiatCodes.GNF);

        /// <summary>
        /// Guatemala Quetzal 
        /// </summary>
        public static CurrencyFiatCode Guatemala_Quetzal_GTQ => CurrencyFiatCode.FromString(Iso3FiatCodes.GTQ);

        /// <summary>
        /// Guinea-Bissau Peso
        /// </summary>
        public static CurrencyFiatCode Guinea_Bissau_Peso => CurrencyFiatCode.FromString(Iso3FiatCodes.GWP);

        /// <summary>
        /// Guyana Dollar 
        /// </summary>
        public static CurrencyFiatCode Guyana_Dollar_GYD => CurrencyFiatCode.FromString(Iso3FiatCodes.GYD);

        /// <summary>
        /// Hong Kong Dollar 
        /// </summary>
        public static CurrencyFiatCode Hong_Kong_Dollar_HKD => CurrencyFiatCode.FromString(Iso3FiatCodes.HKD);

        /// <summary>
        /// Honduras Lempira 
        /// </summary>
        public static CurrencyFiatCode Honduras_Lempira_HNL => CurrencyFiatCode.FromString(Iso3FiatCodes.HNL);

        /// <summary>
        /// Croatian Kuna 
        /// </summary>
        public static CurrencyFiatCode Croatian_Kuna_HRK => CurrencyFiatCode.FromString(Iso3FiatCodes.HRK);

        /// <summary>
        /// Haiti Gourde 
        /// </summary>
        public static CurrencyFiatCode Haiti_Gourde_HTG => CurrencyFiatCode.FromString(Iso3FiatCodes.HTG);

        /// <summary>
        /// Hungarian ForINT 
        /// </summary>
        public static CurrencyFiatCode Hungarian_ForINT_HUF => CurrencyFiatCode.FromString(Iso3FiatCodes.HUF);

        /// <summary>
        /// Indonesian Rupiah 
        /// </summary>
        public static CurrencyFiatCode Indonesian_Rupiah_IDR => CurrencyFiatCode.FromString(Iso3FiatCodes.IDR);

        /// <summary>
        /// Israeli Shekel 
        /// </summary>
        public static CurrencyFiatCode Israeli_Shekel_ILS => CurrencyFiatCode.FromString(Iso3FiatCodes.ILS);

        /// <summary>
        /// Indian Rupee 
        /// </summary>
        public static CurrencyFiatCode Indian_Rupee_INR => CurrencyFiatCode.FromString(Iso3FiatCodes.INR);

        /// <summary>
        /// Iraqi Dinar
        /// </summary>
        public static CurrencyFiatCode Iraqi_Dinar => CurrencyFiatCode.FromString(Iso3FiatCodes.IQD);

        /// <summary>
        /// Iran Rial 
        /// </summary>
        public static CurrencyFiatCode Iran_Rial_IRR => CurrencyFiatCode.FromString(Iso3FiatCodes.IRR);

        /// <summary>
        /// Iceland Krona 
        /// </summary>
        public static CurrencyFiatCode Iceland_Krona_ISK => CurrencyFiatCode.FromString(Iso3FiatCodes.ISK);

        /// <summary>
        /// Jamaican Dollar 
        /// </summary>
        public static CurrencyFiatCode Jamaican_Dollar_JMD => CurrencyFiatCode.FromString(Iso3FiatCodes.JMD);

        /// <summary>
        /// Jordanian Dinar 
        /// </summary>
        public static CurrencyFiatCode Jordanian_Dinar_JOD => CurrencyFiatCode.FromString(Iso3FiatCodes.JOD);

        /// <summary>
        /// Japanese Yen 
        /// </summary>
        public static CurrencyFiatCode Japanese_Yen_JPY => CurrencyFiatCode.FromString(Iso3FiatCodes.JPY);

        /// <summary>
        /// Kenyan Shilling 
        /// </summary>
        public static CurrencyFiatCode Kenyan_Shilling_KES => CurrencyFiatCode.FromString(Iso3FiatCodes.KES);

        /// <summary>
        /// Cambodia Riel 
        /// </summary>
        public static CurrencyFiatCode Cambodia_Riel_KHR => CurrencyFiatCode.FromString(Iso3FiatCodes.KHR);

        /// <summary>
        /// Comoros Franc 
        /// </summary>
        public static CurrencyFiatCode Comoros_Franc_KMF => CurrencyFiatCode.FromString(Iso3FiatCodes.KMF);

        /// <summary>
        /// Korean Won 
        /// </summary>
        public static CurrencyFiatCode Korean_Won_KRW => CurrencyFiatCode.FromString(Iso3FiatCodes.KRW);

        /// <summary>
        /// Kuwaiti Dinar 
        /// </summary>
        public static CurrencyFiatCode Kuwaiti_Dinar_KWD => CurrencyFiatCode.FromString(Iso3FiatCodes.KWD);

        /// <summary>
        /// Cayman Islands Dollar 
        /// </summary>
        public static CurrencyFiatCode Cayman_Islands_Dollar_KYD => CurrencyFiatCode.FromString(Iso3FiatCodes.KYD);

        /// <summary>
        /// Kazakhstan Tenge 
        /// </summary>
        public static CurrencyFiatCode Kazakhstan_Tenge_KZT => CurrencyFiatCode.FromString(Iso3FiatCodes.KZT);

        /// <summary>
        /// Lao Kip 
        /// </summary>
        public static CurrencyFiatCode Lao_Kip_LAK => CurrencyFiatCode.FromString(Iso3FiatCodes.LAK);

        /// <summary>
        /// Lebanese Pound 
        /// </summary>
        public static CurrencyFiatCode Lebanese_Pound_LBP => CurrencyFiatCode.FromString(Iso3FiatCodes.LBP);

        /// <summary>
        /// Sri Lanka Rupee 
        /// </summary>
        public static CurrencyFiatCode Sri_Lanka_Rupee_LKR => CurrencyFiatCode.FromString(Iso3FiatCodes.LKR);

        /// <summary>
        /// Liberian Dollar
        /// </summary>
        public static CurrencyFiatCode Liberian_Dollar => CurrencyFiatCode.FromString(Iso3FiatCodes.LRD);

        /// <summary>
        /// Lesotho Loti 
        /// </summary>
        public static CurrencyFiatCode Lesotho_Loti_LSL => CurrencyFiatCode.FromString(Iso3FiatCodes.LSL);

        /// <summary>
        /// Lithuanian Lita 
        /// </summary>
        public static CurrencyFiatCode Lithuanian_Lita_LTL => CurrencyFiatCode.FromString(Iso3FiatCodes.LTL);

        /// <summary>
        /// Latvian Lat 
        /// </summary>
        public static CurrencyFiatCode Latvian_Lat_LVL => CurrencyFiatCode.FromString(Iso3FiatCodes.LVL);

        /// <summary>
        /// Libyan Dinar 
        /// </summary>
        public static CurrencyFiatCode Libyan_Dinar_LYD => CurrencyFiatCode.FromString(Iso3FiatCodes.LYD);

        /// <summary>
        /// Moroccan Dirham 
        /// </summary>
        public static CurrencyFiatCode Moroccan_Dirham_MAD => CurrencyFiatCode.FromString(Iso3FiatCodes.MAD);

        /// <summary>
        /// Moldovan Leu 
        /// </summary>
        public static CurrencyFiatCode Moldovan_Leu_MDL => CurrencyFiatCode.FromString(Iso3FiatCodes.MDL);

        /// <summary>
        /// Malagasy Franc
        /// </summary>
        public static CurrencyFiatCode Malagasy_Franc => CurrencyFiatCode.FromString(Iso3FiatCodes.MGF);

        /// <summary>
        /// Macedonian Denar 
        /// </summary>
        public static CurrencyFiatCode Macedonian_Denar_MKD => CurrencyFiatCode.FromString(Iso3FiatCodes.MKD);

        /// <summary>
        /// Myanmar Kyat
        /// </summary>
        public static CurrencyFiatCode Myanmar_Kyat => CurrencyFiatCode.FromString(Iso3FiatCodes.MMK);

        /// <summary>
        /// Mongolian Tugrik 
        /// </summary>
        public static CurrencyFiatCode Mongolian_Tugrik_MNT => CurrencyFiatCode.FromString(Iso3FiatCodes.MNT);

        /// <summary>
        /// Macau Pataca 
        /// </summary>
        public static CurrencyFiatCode Macau_Pataca_MOP => CurrencyFiatCode.FromString(Iso3FiatCodes.MOP);

        /// <summary>
        /// Mauritania Ougulya 
        /// </summary>
        public static CurrencyFiatCode Mauritania_Ougulya_MRO => CurrencyFiatCode.FromString(Iso3FiatCodes.MRO);

        /// <summary>
        /// Mauritius Rupee 
        /// </summary>
        public static CurrencyFiatCode Mauritius_Rupee_MUR => CurrencyFiatCode.FromString(Iso3FiatCodes.MUR);

        /// <summary>
        /// Maldives Rufiyaa 
        /// </summary>
        public static CurrencyFiatCode Maldives_Rufiyaa_MVR => CurrencyFiatCode.FromString(Iso3FiatCodes.MVR);

        /// <summary>
        /// Malawi Kwacha 
        /// </summary>
        public static CurrencyFiatCode Malawi_Kwacha_MWK => CurrencyFiatCode.FromString(Iso3FiatCodes.MWK);

        /// <summary>
        /// Mexican Peso 
        /// </summary>
        public static CurrencyFiatCode Mexican_Peso_MXN => CurrencyFiatCode.FromString(Iso3FiatCodes.MXN);

        /// <summary>
        /// Malaysian Ringgit 
        /// </summary>
        public static CurrencyFiatCode Malaysian_Ringgit_MYR => CurrencyFiatCode.FromString(Iso3FiatCodes.MYR);

        /// <summary>
        /// Namibian Dollar 
        /// </summary>
        public static CurrencyFiatCode Namibian_Dollar_NAD => CurrencyFiatCode.FromString(Iso3FiatCodes.NAD);

        /// <summary>
        /// Nigerian Naira 
        /// </summary>
        public static CurrencyFiatCode Nigerian_Naira_NGN => CurrencyFiatCode.FromString(Iso3FiatCodes.NGN);

        /// <summary>
        /// Nicaragua Cordoba 
        /// </summary>
        public static CurrencyFiatCode Nicaragua_Cordoba_NIO => CurrencyFiatCode.FromString(Iso3FiatCodes.NIO);

        /// <summary>
        /// Norwegian Krone 
        /// </summary>
        public static CurrencyFiatCode Norwegian_Krone_NOK => CurrencyFiatCode.FromString(Iso3FiatCodes.NOK);

        /// <summary>
        /// Nepalese Rupee 
        /// </summary>
        public static CurrencyFiatCode Nepalese_Rupee_NPR => CurrencyFiatCode.FromString(Iso3FiatCodes.NPR);

        /// <summary>
        /// New Zealand Dollar 
        /// </summary>
        public static CurrencyFiatCode New_Zealand_Dollar_NZD => CurrencyFiatCode.FromString(Iso3FiatCodes.NZD);

        /// <summary>
        /// Omani Rial 
        /// </summary>
        public static CurrencyFiatCode Omani_Rial_OMR => CurrencyFiatCode.FromString(Iso3FiatCodes.OMR);

        /// <summary>
        /// Panama Balboa 
        /// </summary>
        public static CurrencyFiatCode Panama_Balboa_PAB => CurrencyFiatCode.FromString(Iso3FiatCodes.PAB);

        /// <summary>
        /// Peruvian Nuevo Sol 
        /// </summary>
        public static CurrencyFiatCode Peruvian_Nuevo_Sol_PEN => CurrencyFiatCode.FromString(Iso3FiatCodes.PEN);

        /// <summary>
        /// Papua New Guinea Kina 
        /// </summary>
        public static CurrencyFiatCode Papua_New_Guinea_Kina_PGK => CurrencyFiatCode.FromString(Iso3FiatCodes.PGK);

        /// <summary>
        /// Philippine Peso 
        /// </summary>
        public static CurrencyFiatCode Philippine_Peso_PHP => CurrencyFiatCode.FromString(Iso3FiatCodes.PHP);

        /// <summary>
        /// Pakistani Rupee 
        /// </summary>
        public static CurrencyFiatCode Pakistani_Rupee_PKR => CurrencyFiatCode.FromString(Iso3FiatCodes.PKR);

        /// <summary>
        /// Polish Zloty 
        /// </summary>
        public static CurrencyFiatCode Polish_Zloty_PLN => CurrencyFiatCode.FromString(Iso3FiatCodes.PLN);

        /// <summary>
        /// Paraguayan Guarani 
        /// </summary>
        public static CurrencyFiatCode Paraguayan_Guarani_PYG => CurrencyFiatCode.FromString(Iso3FiatCodes.PYG);

        /// <summary>
        /// Qatar Rial 
        /// </summary>
        public static CurrencyFiatCode Qatar_Rial_QAR => CurrencyFiatCode.FromString(Iso3FiatCodes.QAR);

        /// <summary>
        /// Romanian New Leu 
        /// </summary>
        public static CurrencyFiatCode Romanian_New_Leu_RON => CurrencyFiatCode.FromString(Iso3FiatCodes.RON);

        /// <summary>
        /// Serbian Dinar
        /// </summary>
        public static CurrencyFiatCode Serbian_Dinar => CurrencyFiatCode.FromString(Iso3FiatCodes.RSD);

        /// <summary>
        /// Russian Rouble 
        /// </summary>
        public static CurrencyFiatCode Russian_Rouble_RUB => CurrencyFiatCode.FromString(Iso3FiatCodes.RUB);

        /// <summary>
        /// Rwanda Franc 
        /// </summary>
        public static CurrencyFiatCode Rwanda_Franc_RWF => CurrencyFiatCode.FromString(Iso3FiatCodes.RWF);

        /// <summary>
        /// Saudi Arabian Riyal 
        /// </summary>
        public static CurrencyFiatCode Saudi_Arabian_Riyal_SAR => CurrencyFiatCode.FromString(Iso3FiatCodes.SAR);

        /// <summary>
        /// Seychelles Rupee 
        /// </summary>
        public static CurrencyFiatCode Seychelles_Rupee_SCR => CurrencyFiatCode.FromString(Iso3FiatCodes.SCR);

        /// <summary>
        /// Sudanese Pound
        /// </summary>
        public static CurrencyFiatCode Sudanese_Pound => CurrencyFiatCode.FromString(Iso3FiatCodes.SDG);

        /// <summary>
        /// Swedish Krona 
        /// </summary>
        public static CurrencyFiatCode Swedish_Krona_SEK => CurrencyFiatCode.FromString(Iso3FiatCodes.SEK);

        /// <summary>
        /// Singapore Dollar 
        /// </summary>
        public static CurrencyFiatCode Singapore_Dollar_SGD => CurrencyFiatCode.FromString(Iso3FiatCodes.SGD);

        /// <summary>
        /// St Helena Pound 
        /// </summary>
        public static CurrencyFiatCode St_Helena_Pound_SHP => CurrencyFiatCode.FromString(Iso3FiatCodes.SHP);

        /// <summary>
        /// Slovenian Tolar 
        /// </summary>
        public static CurrencyFiatCode Slovenian_Tolar_SIT => CurrencyFiatCode.FromString(Iso3FiatCodes.SIT);

        /// <summary>
        /// Sierra Leone Leone 
        /// </summary>
        public static CurrencyFiatCode Sierra_Leone_Leone_SLL => CurrencyFiatCode.FromString(Iso3FiatCodes.SLL);

        /// <summary>
        /// Somali Shilling 
        /// </summary>
        public static CurrencyFiatCode Somali_Shilling_SOS => CurrencyFiatCode.FromString(Iso3FiatCodes.SOS);

        /// <summary>
        /// Sao Tome Dobra 
        /// </summary>
        public static CurrencyFiatCode Sao_Tome_Dobra_STD => CurrencyFiatCode.FromString(Iso3FiatCodes.STD);

        /// <summary>
        /// Syrian Pound 
        /// </summary>
        public static CurrencyFiatCode Syrian_Pound_SYP => CurrencyFiatCode.FromString(Iso3FiatCodes.SYP);

        /// <summary>
        /// Swaziland Lilageni 
        /// </summary>
        public static CurrencyFiatCode Swaziland_Lilageni_SZL => CurrencyFiatCode.FromString(Iso3FiatCodes.SZL);

        /// <summary>
        /// Thai Baht 
        /// </summary>
        public static CurrencyFiatCode Thai_Baht_THB => CurrencyFiatCode.FromString(Iso3FiatCodes.THB);

        /// <summary>
        /// Tunisian Dinar 
        /// </summary>
        public static CurrencyFiatCode Tunisian_Dinar_TND => CurrencyFiatCode.FromString(Iso3FiatCodes.TND);

        /// <summary>
        /// Tonga Paanga 
        /// </summary>
        public static CurrencyFiatCode Tonga_Paanga_TOP => CurrencyFiatCode.FromString(Iso3FiatCodes.TOP);

        /// <summary>
        /// Turkish Lira 
        /// </summary>
        public static CurrencyFiatCode Turkish_Lira_TRY => CurrencyFiatCode.FromString(Iso3FiatCodes.TRY);

        /// <summary>
        /// Trinidad&Tobago Dollar 
        /// </summary>
        public static CurrencyFiatCode Trinidad_And_Tobago_Dollar_TTD => CurrencyFiatCode.FromString(Iso3FiatCodes.TTD);

        /// <summary>
        /// Taiwan Dollar 
        /// </summary>
        public static CurrencyFiatCode Taiwan_Dollar_TWD => CurrencyFiatCode.FromString(Iso3FiatCodes.TWD);

        /// <summary>
        /// Tanzanian Shilling 
        /// </summary>
        public static CurrencyFiatCode Tanzanian_Shilling_TZS => CurrencyFiatCode.FromString(Iso3FiatCodes.TZS);

        /// <summary>
        /// Ukraine Hryvnia 
        /// </summary>
        public static CurrencyFiatCode Ukraine_Hryvnia_UAH => CurrencyFiatCode.FromString(Iso3FiatCodes.UAH);

        /// <summary>
        /// Ugandan Shilling 
        /// </summary>
        public static CurrencyFiatCode Ugandan_Shilling_UGX => CurrencyFiatCode.FromString(Iso3FiatCodes.UGX);

        /// <summary>
        /// U.S. Dollar 
        /// </summary>
        public static CurrencyFiatCode US_Dollar_USD => CurrencyFiatCode.FromString(Iso3FiatCodes.USD);

        /// <summary>
        /// Uruguayan New Peso 
        /// </summary>
        public static CurrencyFiatCode Uruguayan_New_Peso_UYU => CurrencyFiatCode.FromString(Iso3FiatCodes.UYU);

        /// <summary>
        /// Vietnam Dong 
        /// </summary>
        public static CurrencyFiatCode Vietnam_Dong_VND => CurrencyFiatCode.FromString(Iso3FiatCodes.VND);

        /// <summary>
        /// Vanuatu Vatu 
        /// </summary>
        public static CurrencyFiatCode Vanuatu_Vatu_VUV => CurrencyFiatCode.FromString(Iso3FiatCodes.VUV);

        /// <summary>
        /// Samoa Tala 
        /// </summary>
        public static CurrencyFiatCode Samoa_Tala_WST => CurrencyFiatCode.FromString(Iso3FiatCodes.WST);

        /// <summary>
        /// CFA Franc (BEAC) 
        /// </summary>
        public static CurrencyFiatCode CFA_Franc_BEAC_XAF => CurrencyFiatCode.FromString(Iso3FiatCodes.XAF);

        /// <summary>
        /// Gold Ounces 
        /// </summary>
        public static CurrencyFiatCode Gold_Ounces_XAU => CurrencyFiatCode.FromString(Iso3FiatCodes.XAU);

        /// <summary>
        /// East Caribbean Dollar 
        /// </summary>
        public static CurrencyFiatCode East_Caribbean_Dollar_XCD => CurrencyFiatCode.FromString(Iso3FiatCodes.XCD);

        /// <summary>
        /// CFA Franc (BCEAO) 
        /// </summary>
        public static CurrencyFiatCode CFA_Franc_BCEAO_XOF => CurrencyFiatCode.FromString(Iso3FiatCodes.XOF);

        /// <summary>
        /// Pacific Franc 
        /// </summary>
        public static CurrencyFiatCode Pacific_Franc_XPF => CurrencyFiatCode.FromString(Iso3FiatCodes.XPF);

        /// <summary>
        /// Yemen Riyal 
        /// </summary>
        public static CurrencyFiatCode Yemen_Riyal_YER => CurrencyFiatCode.FromString(Iso3FiatCodes.YER);

        /// <summary>
        /// South African Rand 
        /// </summary>
        public static CurrencyFiatCode South_African_Rand_ZAR => CurrencyFiatCode.FromString(Iso3FiatCodes.ZAR);

        /// <summary>
        /// Zambian Kwacha 
        /// </summary>
        public static CurrencyFiatCode Zambian_Kwacha_ZMK => CurrencyFiatCode.FromString(Iso3FiatCodes.ZMW);

        /// <summary>
        /// Zimbabwean Dollar
        /// </summary>
        public static CurrencyFiatCode Zimbabwean_Dollar => CurrencyFiatCode.FromString(Iso3FiatCodes.ZWD);
        #endregion
    }
}
