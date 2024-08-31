namespace SafeStashAdminPortalAPI.DTO.Response
{
    public class AccountResponse
    {
        public string Title { get; set; }
        public object Data { get; set; }
        public string Message { get; set; }
        public bool Succeeded { get; set; }
        public bool RequiresTwoFactor { get; set; }
        public bool RequiresPhoneNumberConfirmed { get; set; }
    }
}
