namespace LitService
{
    /// <summary>
    /// 接口返回对象
    /// </summary>
    public class ApiResult
    {
        /// <summary>
        /// 状态码
        /// </summary>
        public ApiCode code { get; set; }

        /// <summary>
        /// 数据
        /// </summary>
        public object data { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        public string msg { get; set; }

        /// <summary>
        /// OK
        /// </summary>
        /// <returns></returns>
        public static ApiResult OK()
        {
            return new ApiResult()
            {
                code = ApiCode.成功,
                msg = "成功"
            };
        }

        /// <summary>
        /// OK
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static ApiResult OK(object data)
        {

            return new ApiResult()
            {
                code = ApiCode.成功,
                data = data,
                msg = "成功"
            };
        }

        /// <summary>
        /// OK
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static ApiResult OK(string msg)
        {
            return new ApiResult()
            {
                code = ApiCode.成功,
                msg = msg
            };
        }

        /// <summary>
        /// OK
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static ApiResult OK(string msg, object data)
        {
            return new ApiResult()
            {
                code = ApiCode.成功,
                data = data,
                msg = msg
            };
        }

        /// <summary>
        /// 数据验证失败
        /// </summary>
        /// <returns></returns>
        public static ApiResult ValidateFail()
        {
            return new ApiResult()
            {
                code = ApiCode.验证失败,
                msg = "验证失败"
            };
        }

        /// <summary>
        /// 数据验证失败
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static ApiResult ValidateFail(string msg)
        {
            return new ApiResult()
            {
                code = ApiCode.验证失败,
                msg = msg
            };
        }

        /// <summary>
        /// 请求异常 400
        /// </summary>
        /// <returns></returns>
        public static ApiResult Failed()
        {
            return new ApiResult()
            {
                code = ApiCode.失败,
                msg = "请求异常"
            };
        }

        /// <summary>
        /// 请求异常 400
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static ApiResult Failed(string msg)
        {
            return new ApiResult()
            {
                code = ApiCode.失败,
                msg = msg
            };
        }

        /// <summary>
        /// 服务器错误 500
        /// </summary>
        /// <returns></returns>
        public static ApiResult Error()
        {
            return new ApiResult()
            {
                code = ApiCode.系统异常,
                msg = "系统异常，请联系系统管理员"
            };
        }

        /// <summary>
        /// 服务器错误 500
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static ApiResult Error(string msg)
        {
            return new ApiResult()
            {
                code = ApiCode.系统异常,
                msg = msg
            };
        }

        /// <summary>
        /// 找不到
        /// </summary>
        /// <returns></returns>
        public static ApiResult NotFound()
        {
            return new ApiResult()
            {
                code = ApiCode.不存在,
                msg = "数据不存在或者已删除"
            };
        }

        /// <summary>
        /// 接口未实现
        /// </summary>
        /// <returns></returns>
        public static ApiResult Unrealized()
        {
            return new ApiResult()
            {
                code = ApiCode.未实现,
                msg = "接口未实现"
            };
        }

        /// <summary>
        /// 没有权限
        /// </summary>
        /// <returns></returns>
        public static ApiResult Forbidden()
        {
            return new ApiResult()
            {
                code = ApiCode.没有权限,
                msg = "没有权限"
            };
        }

        /// <summary>
        /// 用户未登录
        /// </summary>
        /// <returns></returns>
        public static ApiResult Anonymous()
        {
            return new ApiResult()
            {
                code = ApiCode.未登录,
                msg = "用户未登录"
            };
        }


    }

    /// <summary>
    /// API状态码
    /// </summary>
    public enum ApiCode
    {
        /// <summary>
        /// 成功 200
        /// </summary>
        成功 = 200,
        /// <summary>
        /// 验证失败 203
        /// </summary>
        验证失败 = 203,
        /// <summary>
        /// 失败 400
        /// </summary>
        失败 = 400,
        /// <summary>
        /// 系统异常 500
        /// </summary>
        系统异常 = 500,
        /// <summary>
        /// 未登录 401
        /// </summary>
        未登录 = 401,
        /// <summary>
        /// 没有权限 403
        /// </summary>
        没有权限 = 403,
        /// <summary>
        /// 无效凭证  412
        /// </summary>
        无效凭证 = 412,
        /// <summary>
        /// 不存在 404
        /// </summary>
        不存在 = 404,
        /// <summary>
        /// 未实现 410
        /// </summary>
        未实现 = 410,

    };
}
