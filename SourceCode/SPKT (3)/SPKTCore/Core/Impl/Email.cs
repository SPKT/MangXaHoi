using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap;
using System.Net.Mail;
using System.Net;

namespace SPKTCore.Core.Impl
{
    [Pluggable("Default")]
    public class Email:IEmail
    {
        const string TO_EMAIL_ADDRESS = "van01031990@gmail.com";
        const string FROM_EMAIL_ADDRESS = "van01031990@gmail.com";
        const string PASSWORD = "012345678";
        public void SendEmail(string From, string Subject, string Message)
        {
            MailMessage mm = new MailMessage(From, TO_EMAIL_ADDRESS);
            mm.Subject = Subject;
            mm.Body = Message;
            Send(mm);
        }
        public void SendEmail(string To, string CC, string BCC,
                           string Subject, string Message)
        {
            MailMessage mm = new MailMessage(FROM_EMAIL_ADDRESS, To);
            mm.CC.Add(CC);
            mm.Bcc.Add(BCC);
            mm.Subject = Subject;
            mm.Body = Message;
            mm.IsBodyHtml = true;
            Send(mm);
        }
        public void SendEmailTo(string To, string Subject, string Message)
        {
            MailMessage mm = new MailMessage(FROM_EMAIL_ADDRESS, To);
            mm.Subject = Subject;
            mm.Body = Message;
            mm.IsBodyHtml = true;
            Send(mm);
        }
        public void SendEmail(string[] To, string[] CC, string[] BCC,  string Subject, string Message)
        {
            MailMessage mm = new MailMessage();
            foreach (string to in To)
            {
                mm.To.Add(to);
            }
            foreach (string cc in CC)
            {
                mm.CC.Add(cc);
            }
            foreach (string bcc in BCC)
            {
                mm.Bcc.Add(bcc);
            }
            mm.From = new MailAddress(FROM_EMAIL_ADDRESS);
            mm.Subject = Subject;
            mm.Body = Message;
            mm.IsBodyHtml = true;
            Send(mm);
        }
        public void SendIndividualEmailsPerRecipient(string[]
           To, string Subject, string Message)
        {
            foreach (string to in To)
            {
                MailMessage mm = new
                   MailMessage(FROM_EMAIL_ADDRESS, to);
                mm.Subject = Subject;
                mm.Body = Message;
                mm.IsBodyHtml = true;
                Send(mm);
            }
        }
        private void Send(MailMessage Message)
        {
            NetworkCredential m_MailAuthentication = new NetworkCredential(TO_EMAIL_ADDRESS, PASSWORD);
            string smtpClient = "smtp.gmail.com";
            int port = 587;
            SmtpClient smtp = new SmtpClient(smtpClient, port);
            //Enable SSL
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = m_MailAuthentication;
            smtp.Send(Message);
        }


        public void SendEmailAddressVerificationEmail(string Username, string To)
        {
            //TODO: Lay noi dung email tu ben ngoai (database, tham so)
            String emailBody = "Ban da dang ky thanh cong. De hoan thanh dang ky vui long click vao link ben duoi<br>";
            String queryStringValue = Cryptography.Encrypt(Username, ParameterSetting.EmailVerificationEncryptKey);            
            string link = String.Format("{0}?{1}={2}", ParameterSetting.EmailVerificationURL, ParameterSetting.UsernameToVerifyQueryStringName, queryStringValue);
            emailBody += String.Format("<br>Click here to verify: <a href='{0}'>{0}</a>", link);
            SendEmailTo(To,ParameterSetting.VerificationEmailSubject, emailBody);

        }

        public void SendPasswordReminderEmail(string To, string EncryptedPassword, string Username)
        {
            throw new NotImplementedException();
        }
    }
}
