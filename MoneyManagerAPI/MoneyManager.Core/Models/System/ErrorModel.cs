namespace MoneyManager.Core.Models.System
{
    public class ErrorModel
    {
        public bool HasError { get; set; }
        public string? ErrorCode { get; set; }
        public string? ErrorMessage { get; set; }
        public dynamic? ErrorValue { get; set; }

        public ErrorModel()
        {
        }

        public ErrorModel(bool hasError)
        {
            HasError = hasError;
        }

        public ErrorModel(bool hasError, string errorCode, string errorMessage)
        {
            HasError = hasError;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }

        public ErrorModel(bool hasError, string errorCode, string errorMessage, dynamic errorValue)
        {
            HasError = hasError;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            ErrorValue = errorValue;
        }
    }
}
