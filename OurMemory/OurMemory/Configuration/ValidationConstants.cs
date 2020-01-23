namespace OurMemory.Configuration
{
    public static class ValidationConstants
    {
        public const string EMAIL_LENGTH_ERROR_MESSAGE = "Email address must be less than 320 characters";
        public const string PASSWORD_ERROR_MESSAGE = "Password must contain one uppercase, lowercase, digit and 8 to 16 characters";
        public const string PASSWORD_REGEX = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,16}$";
        public const string USERNAME_ERROR_MESSAGE = "Username must be between 8 and 16 characters";        
    }
}
