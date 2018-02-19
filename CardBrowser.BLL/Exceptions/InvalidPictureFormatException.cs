namespace CardBrowser.BLL.Exceptions
{

    #region usings
    using System;
    #endregion

    public class InvalidPictureFormatException: BaseCustomException
    {
        public InvalidPictureFormatException()
        {

        }

        public InvalidPictureFormatException(string message) : base(message)
        {

        }

        public InvalidPictureFormatException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
