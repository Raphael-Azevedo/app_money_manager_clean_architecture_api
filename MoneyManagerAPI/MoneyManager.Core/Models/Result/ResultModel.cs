using MoneyManager.Core.Models.System;

namespace MoneyManager.Core.Models.Result
{
    public class ResultModel
    {
        public bool Success { get; set; }
        public ErrorModel? Error { get; set; }
        public dynamic? ResultData { get; set; }

        public ResultModel()
        {
            Error = new ErrorModel();
        }

        public ResultModel(ErrorModel error, dynamic? resultData = null)
        {
            this.Error = error;
            this.ResultData = resultData;
        }

        public ResultModel(bool success, ErrorModel? error = null, dynamic? resultData = null)
        {
            this.Success = success;
            this.Error = error;
            this.ResultData = resultData;
        }
    }
}
