using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;

namespace GoogleOAuth.Services
{
    public class EmailSender : IEmailSender
    {

        //Step 1. COnstructor
        public EmailSender(IOptions<AuthMessageSenderOptions> optionsAccessor)
        {
            Options = optionsAccessor.Value;
        }

        //step 2. set the options
        public AuthMessageSenderOptions Options { get; }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            throw new NotImplementedException();
        }
    }
}
