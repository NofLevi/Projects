using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check
{
    class smtpHandler
    {
        String smtpServerName;
        String senderaddress;
        string securePassword;
        int smtpPort;
        string subject;
        string body;
        string connString;
        string emailType;
        
        string defultEmail= "yoni700700";
        string defultEmailType = "@Gmail.com";
        string defultPassword = "dhnrgionsycislzr";

        
       
        int  defultport = 587;
        string defultserver = "smtp.gmail.com";
       
        OleDbConnection con;
        HttpClient httpClient = new HttpClient();


        public smtpHandler(bool firstTime)
        {

        }
        public smtpHandler()
        {
            smtpConstFunc();

        }

        //start the class constructor and sets up the smtp cridentils
        private void smtpConstFunc()
        {
            connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            con = new OleDbConnection(connString);

            string SMTPSetUpChack;

            using (OleDbCommand cmd = new OleDbCommand("SELECT Email FROM EmailLogin", con))//displays email in use
            {
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Read();

                // MessageBox.Show(reader.GetValue(0).ToString());
                SMTPSetUpChack = reader.GetValue(0).ToString();


                con.Close();
            }






            if (SMTPSetUpChack.ToLower() != "n/a".ToLower())
            {

                using (OleDbCommand cmd = new OleDbCommand("SELECT SecurePassword FROM EmailLogin", con))//displays email in use
                {
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    //MessageBox.Show(reader.GetValue(0).ToString());
                    securePassword = reader.GetValue(0).ToString();


                    con.Close();



                }



                using (OleDbCommand cmd = new OleDbCommand("SELECT Email FROM EmailLogin", con))//displays email in use
                {
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    // MessageBox.Show(reader.GetValue(0).ToString());
                    senderaddress = reader.GetValue(0).ToString();


                    con.Close();
                }


                {
                    using (OleDbCommand cmd = new OleDbCommand("SELECT EmailType FROM EmailLogin", con))//displays email in use
                    {
                        con.Open();
                        OleDbDataReader reader = cmd.ExecuteReader();
                        reader.Read();

                        // MessageBox.Show(reader.GetValue(0).ToString());


                        emailType = reader.GetValue(0).ToString();
                        senderaddress = senderaddress + reader.GetValue(0).ToString();
                        con.Close();
                    }

                }


                if (emailType.ToLower() == "@gmail.com")
                {
                    Console.WriteLine("gmail server type");
                    smtpServerName = "smtp.gmail.com";
                    smtpPort = 587;
                    //465

                }
                if (emailType.ToLower() == "@yahoo.com")
                {
                    Console.WriteLine("yahoo server type");
                    smtpServerName = "smtp.mail.yahoo.com";
                    smtpPort = 587;

                }
                if (emailType.ToLower() == "@hotmail.com")
                {
                    Console.WriteLine("hotmail server type");
                    smtpServerName = "smtp.live.com";
                    smtpPort = 25;

                }



            }
            else
            {
                Console.WriteLine("SMTP Setup needed");
            }
        }

        // func to send a mail to multi reciver
        public bool MailerSender(List<String> receiver, string Title , string body)
        {
            int messagesNotSent = receiver.Count;

            for (int i = 0; receiver.Count > i; i++)
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient(smtpServerName);

                    mail.From = new MailAddress(senderaddress);
                    mail.To.Add(receiver[i]);

                    mail.Subject = Title;
                    mail.Body = body;

                    SmtpServer.Port = smtpPort;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(senderaddress, securePassword);
                    SmtpServer.EnableSsl = true;

                    //SmtpServer.Send(mail);
                    SmtpServer.SendMailAsync(mail);
                     //MessageBox.Show("mail Sent");



                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: \n" + ex.ToString());
                   // MessageBox.Show("server name :" + smtpServerName + " Senderaddress:" + senderaddress + " securePassword:" + securePassword
                      //  + "port:" + smtpPort + " subject:" + subject + " body:" + body);
                    messagesNotSent--;
                }
            }
            if (messagesNotSent == receiver.Count)
            {
                MessageBox.Show("All mail succesefully !! horay" );
                return true;
            }
            if(messagesNotSent == 0)
            {
                MessageBox.Show("no messages sent at all please chack your email and email secure password , if the problem prosists please contact nof "  );
                return false;
            }else
            {
                MessageBox.Show("some messages where sent succesefully "+receiver.Count +"/"+ messagesNotSent);
                return true;
            }


        }

        // func to send a mail to multi reciver with 1 attechment
        public bool MailerSender(List<String> receiver, string Title, string body, string attachment)
        {
            int messagesNotSent = receiver.Count;

            for (int i = 0; receiver.Count > i; i++)
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient(smtpServerName);

                    mail.From = new MailAddress(senderaddress);
                    mail.Attachments.Add(new Attachment(attachment));
                    mail.To.Add(receiver[i]);

                    mail.Subject = Title;
                    mail.Body = body;

                    SmtpServer.Port = smtpPort;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(senderaddress, securePassword);
                    SmtpServer.EnableSsl = true;

                    //SmtpServer.Send(mail);
                    SmtpServer.SendMailAsync(mail);
                     //MessageBox.Show("mail Sent");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: \n" + ex.ToString());
                    // MessageBox.Show("server name :" + smtpServerName + " Senderaddress:" + senderaddress + " securePassword:" + securePassword
                    //  + "port:" + smtpPort + " subject:" + subject + " body:" + body);
                    messagesNotSent--;
                }
            }
            if (messagesNotSent == receiver.Count)
            {
                MessageBox.Show("All mail succesefully !! horay");
                return true;
            }
            if (messagesNotSent == 0)
            {
                MessageBox.Show("no messages sent at all please chack your email and email secure password , if the problem prosists please contact nof");
                return false;
            }
            else
            {
                MessageBox.Show("some messages where sent succesefully " + receiver.Count + "/" + messagesNotSent);
                return true;
            }
        }

        // func to send a mail to multi reciver with multi attechment
        public bool MailerSender(List<String> receiver, string Title, string body, List <string> attachment)
        {
            int messagesNotSent = receiver.Count;

            for (int i = 0; receiver.Count > i; i++)
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient(smtpServerName);

                    mail.From = new MailAddress(senderaddress);
                    for (int J = 0; J < attachment.Count; J++)
                    {
                        mail.Attachments.Add(new Attachment(attachment[J]));
                    }
                   
                    mail.To.Add(receiver[i]);

                    mail.Subject = Title;
                    mail.Body = body;

                    SmtpServer.Port = smtpPort;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(senderaddress, securePassword);
                    SmtpServer.EnableSsl = true;

                    //SmtpServer.Send(mail);
                    SmtpServer.SendMailAsync(mail);
                   // MessageBox.Show("mail Sent");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: \n" + ex.ToString());
                    // MessageBox.Show("server name :" + smtpServerName + " Senderaddress:" + senderaddress + " securePassword:" + securePassword
                    //  + "port:" + smtpPort + " subject:" + subject + " body:" + body);
                    messagesNotSent--;
                }
            }
            if (messagesNotSent == receiver.Count)
            {
                MessageBox.Show("All mail succesefully !! horay");
                return true;
            }
            if (messagesNotSent == 0)
            {
                MessageBox.Show("no messages sent at all please chack your email and email secure password , if the problem prosists please contact nof");
                return false;
            }
            else
            {
                MessageBox.Show("some messages where sent succesefully " + receiver.Count + "/" + messagesNotSent);
                return true;
            }


        }
        public List<string> CustomerTableToList()
        {
            using (OleDbCommand cmd = new OleDbCommand("SELECT Email FROM CustomersTable", con))// note to self change list wit Email
            {
                List<string> list = new List<string>();
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(reader.GetValue(0).ToString());
                 //   Console.WriteLine(reader.GetValue(0).ToString());
                }

                con.Close();

                return list;
            }
        }

        public bool EmailTestFunc()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(smtpServerName);

                mail.From = new MailAddress(senderaddress);
                mail.To.Add(senderaddress);

                mail.Subject = "Store email Test";
                mail.Body = "if you have gotten this email the program has connected to your bussnies email ";

                SmtpServer.Port = smtpPort;
                SmtpServer.Credentials = new System.Net.NetworkCredential(senderaddress, securePassword);
                SmtpServer.EnableSsl = true;

                //SmtpServer.Send(mail);
                SmtpServer.SendMailAsync(mail);
                //  MessageBox.Show("mail Sent , Its a free servise so it takes time be patiant");
                // MessageBox.Show("sender:" + senderaddress + "password: " + securePassword);
                MessageBox.Show("test mail sent , please chack you registered Email , this may take acouple of minutes . \n if not email was sent please chack the Email settings or contanct costumer support.");
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: \n" + ex.ToString());
                MessageBox.Show("ERROR: \n" + ex.ToString());
                //  + "port:" + smtpPort + " subject:" + subject + " body:" + body);
                return false;
            }
        }

        // func to send a mail to 1 reciver
        public void EmailOneFunc(string reciver, string body, string title)
        {
            for (int i = 0; 1 > i; i++)
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient(smtpServerName);

                    mail.From = new MailAddress(senderaddress);
                    mail.To.Add(reciver);

                    mail.Subject = title;
                    mail.Body = body;

                    SmtpServer.Port = smtpPort;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(senderaddress, securePassword);
                    SmtpServer.EnableSsl = true;

                   // SmtpServer.Send(mail);
                    SmtpServer.SendMailAsync(mail);
                     MessageBox.Show("mail Sent");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: \n" + ex.ToString());
                    // MessageBox.Show("server name :" + smtpServerName + " Senderaddress:" + senderaddress + " securePassword:" + securePassword
                    //  + "port:" + smtpPort + " subject:" + subject + " body:" + body);
                    // messagesNotSent--;
                }
            }
        }

        // func to send a mail to 1 reciver with 1 attachment
        public void EmailOneFunc(string reciver, string body, string title, string attachment)
        {
            for (int i = 0; 1 > i; i++)
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient(smtpServerName);

                    mail.From = new MailAddress(senderaddress);
                    mail.Attachments.Add(new Attachment(attachment));
                    mail.To.Add(reciver);

                    mail.Subject = title;
                    mail.Body = body;

                    SmtpServer.Port = smtpPort;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(senderaddress, securePassword);
                    SmtpServer.EnableSsl = true;

                    //SmtpServer.Send(mail);
                    SmtpServer.SendMailAsync(mail);
                     MessageBox.Show("mail Sent");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: \n" + ex.ToString());
                    // MessageBox.Show("server name :" + smtpServerName + " Senderaddress:" + senderaddress + " securePassword:" + securePassword
                    //  + "port:" + smtpPort + " subject:" + subject + " body:" + body);
                   
                }
            }
           



        }

        // func to send a mail to 1 reciver with multi attachment
        public void EmailOneFunc(string reciver, string body, string title, List<string> attachment)
        {
            for (int i = 0; 1 > i; i++)
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient(smtpServerName);

                    mail.From = new MailAddress(senderaddress);
                    for (int J = 0; J < attachment.Count; J++)
                    {
                        mail.Attachments.Add(new Attachment(attachment[J]));
                    }

                    mail.To.Add(reciver);

                    mail.Subject = title;
                    mail.Body = body;

                    SmtpServer.Port = smtpPort;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(senderaddress, securePassword);
                    SmtpServer.EnableSsl = true;

                    //SmtpServer.Send(mail);
                    SmtpServer.SendMailAsync(mail);
                     MessageBox.Show("mail Sent");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: \n" + ex.ToString());
                    // MessageBox.Show("server name :" + smtpServerName + " Senderaddress:" + senderaddress + " securePassword:" + securePassword
                    //  + "port:" + smtpPort + " subject:" + subject + " body:" + body);
                    
                }
            }
        }



        // send code to selected email to verify
        public string FirstVerifyEmailFunc(string name, string Emailtype, string password)
        {
            string code = codeGennorator();
            string servername="N/a";
            int port = 0;
            string sender = name + Emailtype;
            string title = "Email verifycation request";
            string body = "the code beening sent here is to verify your email for use in the store managment program for persenal use  \n " +
                    "if you didnt request this please ignore the Email \n" +
                    "the code is :" + code;

            if (Emailtype.ToLower() == "@Gmail.com".ToLower())
            {
                Console.WriteLine("gmail server type");
                servername = "smtp.gmail.com";
                port = 587;

            }
            if (Emailtype.ToLower() == "@Yahoo.com".ToLower())
            {
                Console.WriteLine("yahoo server type");
                servername = "smtp.mail.yahoo.com";
                port = 587;

            }
            if (Emailtype.ToLower() == "@Hotmail.com".ToLower())
            {
                Console.WriteLine("hotmail server type");
                servername = "smtp.live.com";
                port = 25;

            }


            
            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(servername);

                mail.From = new MailAddress(sender);
                mail.To.Add(sender);

                mail.Subject = title;
                mail.Body = body;

                SmtpServer.Port = port;
                SmtpServer.Credentials = new System.Net.NetworkCredential(sender, password);
                SmtpServer.EnableSsl = true;

                // SmtpServer.Send(mail);
                SmtpServer.SendMailAsync(mail);
                MessageBox.Show("mail Sent");
                //MessageBox.Show("sender:" + sender + "="+defultEmail+defultEmailType + " password:" +  password + "="+defultPassword+" server:"+servername+"="+defultserver+" port:"+port+'='+defultport);
                return code;







                /*

               MailMessage mail = new MailMessage();
               SmtpClient SmtpServer = new SmtpClient(servername);

               mail.From = new MailAddress(sender);
               mail.To.Add(sender);

               mail.Subject = title;
               mail.Body = body;

               SmtpServer.Port = port;
               SmtpServer.Credentials = new System.Net.NetworkCredential(sender, password);
               SmtpServer.EnableSsl = true;

               //SmtpServer.Send(mail);
               SmtpServer.SendMailAsync(mail);
               MessageBox.Show("mail Sent , Its a free servise so it takes time be patiant");
              
               return code;



                   MailMessage mail = new MailMessage();
                   SmtpClient SmtpServer = new SmtpClient(smtpServerName);

                   mail.From = new MailAddress(senderaddress);
                   mail.To.Add(reciver);

                   mail.Subject = title;
                   mail.Body = body;

                   SmtpServer.Port = smtpPort;
                   SmtpServer.Credentials = new System.Net.NetworkCredential(senderaddress, securePassword);
                   SmtpServer.EnableSsl = true;

                  // SmtpServer.Send(mail);
                   SmtpServer.SendMailAsync(mail);
                    MessageBox.Show("mail Sent");
                */










            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: \n" + ex.ToString());
              //  MessageBox.Show("ERROR: \n" + ex.ToString());
               
                return "false";
            }
        }

        // gets the code and see if text box matchs the code
        public string VerifyEmail(string name , string EmailType,string password  )
        {
            string code;

            code = FirstVerifyEmailFunc(name, EmailType, password);
            if(code== "false")
            {
                MessageBox.Show("Email was unable to be sent please try again after making sure all Email name and app password where ok");
                return "false";
            }
            else
            {
                return code;
            }
        }


        // send code to verify email 
        public string PersonalAccountEmailChack(string reciver)
        {



            string code = codeGennorator();
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(defultserver);

                mail.From = new MailAddress(defultEmail + defultEmailType);
                mail.To.Add(reciver);

                mail.Subject = "first entry code";
                mail.Body = "here is the code "+code;

                SmtpServer.Port = defultport;
                SmtpServer.Credentials = new System.Net.NetworkCredential(defultEmail+ defultEmailType, defultPassword);
                SmtpServer.EnableSsl = true;

                //SmtpServer.Send(mail);
                SmtpServer.SendMailAsync(mail);
                //  MessageBox.Show("mail Sent , Its a free servise so it takes time be patiant");
                // MessageBox.Show("sender:" + senderaddress + "password: " + securePassword);
                return code;

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: \n" + ex.ToString());
                MessageBox.Show("ERROR: \n" + ex.ToString());
                //  + "port:" + smtpPort + " subject:" + subject + " body:" + body);
                return null ;
            }

        }

        // genorats code for email chacking
        public String codeGennorator()
        {
            Random rnd = new Random();
            //65= A
            //90= Z
            char first = System.Convert.ToChar( rnd.Next(65, 91));
            int second = rnd.Next(1, 10);
            int three = rnd.Next(1, 10);
            char four = System.Convert.ToChar(rnd.Next(65, 91));
            int fith = rnd.Next(1, 10);
            int sixth = rnd.Next(1, 10);

            return  first.ToString() + second.ToString() + three.ToString() + four.ToString() + fith.ToString() + sixth.ToString();
        }

        //send back-up file to work email
        public void BackupSender(string body, string title, string attachment)
        {
            //MessageBox.Show("check");
            for (int i = 0; 1 > i; i++)
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient(smtpServerName);
                    
                    mail.From = new MailAddress(senderaddress);
                    mail.Attachments.Add(new Attachment(attachment));
                    mail.To.Add(senderaddress);
                    
                    mail.Subject = title;
                    mail.Body = body;

                    SmtpServer.Port = smtpPort;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(senderaddress, securePassword);
                    SmtpServer.EnableSsl = true;

                    //SmtpServer.Send(mail);
                    SmtpServer.SendMailAsync(mail);
                    MessageBox.Show("mail Sent");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: \n" + ex.ToString());
                    // MessageBox.Show("server name :" + smtpServerName + " Senderaddress:" + senderaddress + " securePassword:" + securePassword
                    //  + "port:" + smtpPort + " subject:" + subject + " body:" + body);

                }
            }
        }
    }
}

