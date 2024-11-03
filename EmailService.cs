using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

public class EmailService
{
    private readonly string smtpHost = "smtp.office365.com"; // For Outlook.com or Office 365
    private readonly int smtpPort = 587; // Port for TLS/STARTTLS
    private readonly string senderEmail;
    private readonly string senderPassword;

    public EmailService(string senderEmail, string senderPassword)
    {
        this.senderEmail = senderEmail;
        this.senderPassword = senderPassword;
    }

    public async Task SendEmailAsync(string recipientEmail, string subject, string body, string pdfFilePath)
    {
        try
        {
            using (var client = new SmtpClient(smtpHost, smtpPort))
            {
                client.Credentials = new NetworkCredential(senderEmail, senderPassword);
                client.EnableSsl = true;

                using (var mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(senderEmail);
                    mailMessage.To.Add(recipientEmail);
                    mailMessage.Subject = subject;
                    mailMessage.Body = body;
                    mailMessage.IsBodyHtml = true; // Set to true if the body is HTML formatted

                    // Add PDF attachment
                    if (File.Exists(pdfFilePath))
                    {
                        var attachment = new Attachment(pdfFilePath);
                        mailMessage.Attachments.Add(attachment);
                    }
                    else
                    {
                        Console.WriteLine("PDF file not found at specified path.");
                    }

                    await client.SendMailAsync(mailMessage);
                    Console.WriteLine("Email sent successfully with attachment.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error sending email: {ex.Message}");
        }
    }
}