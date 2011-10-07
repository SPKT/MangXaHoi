using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap;

namespace SPKTCore.Core
{
    [PluginFamily("Default")]
    public interface IEmail
    {
        void SendEmail(string From, string Subject, string Message);
        void SendEmail(string To, string CC, string BCC, string Subject, string Message);
        void SendEmail(string[] To, string[] CC, string[] BCC, string Subject, string Message);
        void SendIndividualEmailsPerRecipient(string[] To, string Subject, string Message);
        void SendEmailAddressVerificationEmail(string Username, string To);
        void SendPasswordReminderEmail(string To, string EncryptedPassword, string Username);
        void SendEmailTo(string To, string Subject, string Message);
    }
}
