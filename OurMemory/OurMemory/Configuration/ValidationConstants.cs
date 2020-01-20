namespace OurMemory.Configuration
{
    public static class ValidationConstants
    {
        public const string EMAIL_LENGTH_ERROR_MESSAGE = "Email address must be less than 320 characters";
        public const string PASSWORD_ERROR_MESSAGE = "Password must contain one uppercase, lowercase, digit and special character. Password must be at least 8 digits.";
        public const string PASSWORD_REGEX = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
    }
}
