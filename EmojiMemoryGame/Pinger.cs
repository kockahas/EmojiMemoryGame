using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Text;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Web;
using System.Runtime.CompilerServices;

namespace EmojiMemoryGame
{
    public static class  Pinger
    {
        
        public static bool Ping(string url)
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send(url, 400);
                if (reply != null)
                    return true;
            }
            catch { }
            return false;
        }

        public static bool chk_server()
        {
            string result = string.Empty;
            string data = string.Empty;
            ASCIIEncoding ascii = new ASCIIEncoding();

            data += string.Format("{0}={1}", "ChkSRV", "ChkOK?");

            byte[] bytesarr = ascii.GetBytes(data);
            try
            {
                WebRequest rq = WebRequest.Create("http://{Server addres!!!}/chksrv.php");

                rq.Method = "POST";
                rq.ContentType = "application/x-www-form-urlencoded";
                rq.ContentLength = bytesarr.Length;
                rq.Timeout = 300;

                Stream streamwriter = rq.GetRequestStream();
                streamwriter.Write(bytesarr, 0, bytesarr.Length);
                streamwriter.Close();

                WebResponse rp = rq.GetResponse();
                streamwriter = rp.GetResponseStream();

                StreamReader sr = new System.IO.StreamReader(streamwriter);
                result = sr.ReadToEnd();
                sr.Close();
                result = result.Trim();
            }
            catch
            {
                return false;
            }
            if (result == "ChkOK?") return true;
            else return false;
        }
       

        public static string send_com_post(Dictionary<string, string> data)
        {
            string result = string.Empty;
            ASCIIEncoding ascii = new ASCIIEncoding();
            StringBuilder buildedData = new StringBuilder();
            foreach (KeyValuePair<string, string> element in data)
            {
                buildedData.Append(HttpUtility.UrlEncode(element.Key)).Append("=").Append(HttpUtility.UrlEncode(element.Value ?? "")).Append("&");
            }
            string postData = buildedData.ToString(0, buildedData.Length - 1);
            byte[] bytearr = ascii.GetBytes(postData);
            try
            {
                WebRequest rq = WebRequest.Create("http://{Server addres!!!}/com.php");

                rq.Method = "POST";
                rq.ContentType = "application/x-www-form-urlencoded";
                rq.ContentLength = bytearr.Length;
                rq.Timeout = 1000;

                Stream streamwriter = rq.GetRequestStream();
                streamwriter.Write(bytearr, 0, bytearr.Length);
                streamwriter.Close();

                WebResponse response = rq.GetResponse();
                streamwriter = response.GetResponseStream();

                StreamReader sr = new System.IO.StreamReader(streamwriter);
                result = sr.ReadToEnd();
                sr.Close();
                result = result.TrimEnd();
            }
            catch
            {
                return null;
            }
            return result;
        }
    }

}
 
