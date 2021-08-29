using System;
using System.Collections.Generic;
using System.Text;

namespace Azihub.GlobalData.Base.Networking.MediaTypes.Exceptions
{
    public class InvalidMediaTypeException : Exception
    {
        public InvalidMediaTypeException(string invalidData) : base($"Invalid media type was provided: {invalidData}")
        {
            InvalidData = invalidData;
        }

        public string InvalidData { get; }
    }
}
