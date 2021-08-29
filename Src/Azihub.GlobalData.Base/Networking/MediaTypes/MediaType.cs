using Azihub.GlobalData.Base.Networking.MediaTypes.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azihub.GlobalData.Base.Networking.MediaTypes
{
    public partial class MediaType
    {
        private MediaType(string value, string[] extensions, string[] reference)
        {
            Value = value;
            Extensions = extensions;
            Reference = reference;
        }
        public string Value { get; set; }
        public string[] Extensions { get; set; }
        public string[] Reference { get; set; }

        public static MediaType FromString(string typeString)
        {
            typeString = typeString.Trim().ToLower();

            if (string.IsNullOrEmpty(typeString))
                throw new InvalidMediaTypeException(typeString);

            if (MediaTypeDict.TryGetValue(typeString, out MediaType mediaType))
                return mediaType;

            throw new InvalidMediaTypeException(typeString);
        }


        /// <summary>
        /// Validate a Top Level Domain
        /// </summary>
        /// <param name="tld"></param>
        /// <returns></returns>
        public static bool IsValid(string typeString)
        {
            typeString = typeString.Trim().ToUpper();

            if (string.IsNullOrEmpty(typeString))
                return false;

            if (MediaTypeDict.ContainsKey(typeString))
                return true;

            return false;
        }
    }
}
