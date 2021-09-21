using Azihub.GlobalData.Base.Networking.MediaTypes.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azihub.GlobalData.Base.Networking.MediaTypes
{
    /// <summary>
    /// https://www.iana.org/assignments/media-types/media-types.xhtml
    /// </summary>
    public partial class MediaType : IEquatable<MediaType>
    {
        private MediaType(string value, string[] extensions, string[] reference)
        {
            Value = value;
            Extensions = extensions;
            Reference = reference;
        }

        /// <summary>
        /// String value of file MIME format (Example: "text/plain")
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// File extension (example .txt).
        /// </summary>
        public string[] Extensions { get; set; }


        /// <summary>
        /// IANA's reference field (Work in progress)
        /// </summary>
        public string[] Reference { get; set; }

        /// <summary>
        /// Create object from string value. this will also validate if string value is a correct match to a valid MIME type.
        /// </summary>
        /// <param name="typeString"></param>
        /// <returns></returns>
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
        /// <param name="typeString"></param>
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

        /// <summary>
        /// Compare object to object based on <see cref="Value"/> property.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(MediaType other)
        {
            return Value == other.Value;
        }
    }
}
