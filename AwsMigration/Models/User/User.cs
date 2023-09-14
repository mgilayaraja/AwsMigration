namespace AwsMigration.Models.User
{
    public class User
    {
        public Guid UserId { get; set; }
        public string EmailAddress { get; set; } = string.Empty;
    }
}
