﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class GlobalBL
    {
        static volunteeringEntities1 volunteeringET = new volunteeringEntities1();

        //שולחת מיל להורה
        public static bool SendEmail(string email, string subject, string body)
        {
            try
            {
                //using (MailMessage mail = new MailMessage())
                //{
                //    mail.From = new MailAddress("tyfee20@gmail.com");
                //    mail.To.Add("miriamrot25@gmail.com");
                //    mail.Subject = "Hello World";
                //    mail.Body = "<h1>Hello</h1>";
                //    mail.IsBodyHtml = true;
                //  //  mail.Attachments.Add(new Attachment("C:\\file.zip"));

                //    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                //    {
                //        smtp.Credentials = new NetworkCredential("tyfee20@gmail.com", "s4s5s1s3s5");
                //        smtp.EnableSsl = true;
                //        smtp.Send(mail);
                //    }
                //}

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("tyfee20@gmail.com");
                mail.To.Add(email);
                mail.Subject = subject;
                mail.IsBodyHtml = true;
                mail.Body = body;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new NetworkCredential("tyfee20@gmail.com", "s4s5s1s3s5");

                SmtpServer.EnableSsl = true;

                SmtpServer.UseDefaultCredentials = true;
                SmtpServer.Send(mail);
                return true;

            }
            catch (Exception ex)
            {
                var exc = ex;
                return false;
            }

        }
        //מגרילה וכותבת שם משתמש וסיסמא
        public static string ToRaffleAndPostUserNameAndPassword()
        {
            Random rnd = new Random();
            string password;
            int minChar = (int)'a';
            int maxChar = (int)'z';
            StringBuilder passwordBuilder = new StringBuilder();

            passwordBuilder = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                passwordBuilder.Append(rnd.Next(1, 9));
                passwordBuilder.Append((char)rnd.Next(minChar, maxChar));
            }
            password = passwordBuilder.ToString();
            return password;
        }
        ////בדיקת סוג משתמש
        //public static object ReturnsUserType(string userName, string password)
        //{
        //    family f = volunteeringET.family.FirstOrDefault(family=>family.password==password);
        //    secretary s = volunteeringET.secretary.FirstOrDefault(sec=>sec.password==password);
        //    volunteer v = volunteeringET.volunteer.FirstOrDefault(volu=>volu.password==password);
        //    if (f != null)
        //        return f;
        //    else if (s != null)
        //        return s;
        //    else if (v != null)
        //        return v;
        //    else
        //        return null;
        //}
    }
}

