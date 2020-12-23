
public class UserAuthData : IUserAuthData
{
    /// <summary>
    /// 資料編號
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 帳號
    /// </summary>
    public string Account { get; set; }

    /// <summary>
    /// 密碼
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// 使用者名稱
    /// </summary>
    public string UserName { get; set; }
}
