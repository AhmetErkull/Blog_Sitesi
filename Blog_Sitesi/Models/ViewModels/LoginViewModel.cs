namespace Blog_Sitesi.Models.ViewModels
{
    public class LoginViewModel
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public string Role {  get; set; }
        public bool KeepLoggedIn { get; set; }
    }
}
