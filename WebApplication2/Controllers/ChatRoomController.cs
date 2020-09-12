using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ChatRoomController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public static bool SendEmail(string to, string subject, string body, bool isHtml, string displayNameFrom)
        {
          
            try
            {

                var mySmtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    UseDefaultCredentials = false,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    EnableSsl = true
                };

                var basicAuthenticationInfo = new
                    System.Net.NetworkCredential("ahmed00078000@gmail.com", "");
                mySmtpClient.Credentials = basicAuthenticationInfo;


                var fromEmail = new MailAddress("ahmed00078000@gmail.com", displayNameFrom);
                var toEmail = new MailAddress(to);
                var myMail = new MailMessage(fromEmail, toEmail)
                {
                    Subject = subject,
                    SubjectEncoding = System.Text.Encoding.UTF8,
                    Body = body,
                    BodyEncoding = System.Text.Encoding.UTF8,
                    IsBodyHtml = isHtml
                };

                mySmtpClient.Send(myMail);
            }
            catch (SmtpException exception)
            {
                return false;
            }
            return true;
        }
        [HttpPost]
        public IActionResult SendEmail(string email)
        {
            var body = "Dear,\n You are invitied to a chatroom to join please use the link below: www.google.com";
            var result = SendEmail(email,"An invitation to a chatroom",body,false,"Chatroom");
            return View("Index");
        }
       
        [HttpPost]
        public IActionResult GetDetails(string txtName, string from)
        {
            SaveChat umodel = new SaveChat();
            umodel.Chats = txtName;
            umodel.From = from;


                int result = umodel.SaveDetails();
            if (result > 0)
            {
                ViewBag.Result = "Data Saved Successfully";
            }
            else
            {
                ViewBag.Result = "Something Went Wrong";
            }
            return View("Index");
        }
    }


}
