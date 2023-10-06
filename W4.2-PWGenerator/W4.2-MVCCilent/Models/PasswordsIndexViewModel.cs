namespace W4._2_MVCCilent.Models
{
    public class PasswordsIndexViewModel
    {
        public string WellcomeMessage { get; set; }

        public string Password { get; set; }

        public List<string> Passwords { get; set; }

        public int PasswordLenght { get; set; }

        public bool IncludeNumbers { get; set; }

        public bool IncludeLowerCaseChars { get; set; }

        public bool IncludeUpperCaseChars { get; set; }

        public bool IncludeSpecialChars { get; set; }
    }
}
