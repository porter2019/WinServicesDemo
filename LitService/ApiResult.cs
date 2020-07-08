namespace LitService
{
    public class ApiResult
    {
        public ApiCode code { get; set; }

        public object data { get; set; }

        public string msg { get; set; }

        public static ApiResult OK()
        {
            return new ApiResult()
            {
                code = ApiCode.成功,
                msg = "成功"
            };
        }

        public static ApiResult OK(object data)
        {

            return new ApiResult()
            {
                code = ApiCode.成功,
                data = data,
                msg = "成功"
            };
        }

        public static ApiResult OK(string msg)
        {
            return new ApiResult()
            {
                code = ApiCode.成功,
                msg = msg
            };
        }

        public static ApiResult OK(string msg, object data)
        {
            return new ApiResult()
            {
                code = ApiCode.成功,
                data = data,
                msg = msg
            };
        }

        public static ApiResult ValidateFail()
        {
            return new ApiResult()
            {
                code = ApiCode.验证失败,
                msg = "验证失败"
            };
        }

        public static ApiResult ValidateFail(string msg)
        {
            return new ApiResult()
            {
                code = ApiCode.验证失败,
                msg = msg
            };
        }

        public static ApiResult Failed()
        {
            return new ApiResult()
            {
                code = ApiCode.失败,
                msg = "请求异常"
            };
        }

        public static ApiResult Failed(string msg)
        {
            return new ApiResult()
            {
                code = ApiCode.失败,
                msg = msg
            };
        }

        public static ApiResult Error()
        {
            return new ApiResult()
            {
                code = ApiCode.系统异常,
                msg = "系统异常，请联系系统管理员"
            };
        }

        public static ApiResult Error(string msg)
        {
            return new ApiResult()
            {
                code = ApiCode.系统异常,
                msg = msg
            };
        }


        public static ApiResult NotFound()
        {
            return new ApiResult()
            {
                code = ApiCode.不存在,
                msg = "数据不存在或者已删除"
            };
        }

        public static ApiResult Unrealized()
        {
            return new ApiResult()
            {
                code = ApiCode.未实现,
                msg = "接口未实现"
            };
        }

        public static ApiResult Forbidden()
        {
            return new ApiResult()
            {
                code = ApiCode.没有权限,
                msg = "没有权限"
            };
        }

        public static ApiResult Anonymous()
        {
            return new ApiResult()
            {
                code = ApiCode.未登录,
                msg = "用户未登录"
            };
        }


    }


    public enum ApiCode
    {
        成功 = 200,
        验证失败 = 203,
        失败 = 400,
        系统异常 = 500,
        未登录 = 401,
        没有权限 = 403,
        无效凭证 = 412,
        不存在 = 404,
        未实现 = 410,

    };
}
