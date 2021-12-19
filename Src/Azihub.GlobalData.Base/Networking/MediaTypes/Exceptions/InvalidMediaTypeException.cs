using System;

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
