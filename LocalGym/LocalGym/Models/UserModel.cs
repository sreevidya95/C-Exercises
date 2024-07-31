namespace LocalGym.Models
{
    /// <summary>
    /// Returns the User info like username and password
    /// </summary>
    public class UserModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool ValidateLogin(UserModel user)
        {

            if (user.UserName == "sree" && user.Password == "123456")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
