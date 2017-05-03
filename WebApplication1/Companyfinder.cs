using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;
using System.IO;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataTable orgtable = new DataTable();
        
        public static class Companyfinder
        {
            public static string[] orgData = new string[6];

            public static List<Portfolio> portfolioList = new List<Portfolio>();
            public static List<JToken> newList = new List<JToken>();
            static string temp { get; set; }


            public static string Domain(string str)
            {

                string http = "https://api.fullcontact.com/v2/company/lookup.json?domain=";
                string appendEnd = "&prettyPrint=true";
                StringBuilder SB = new StringBuilder(http);
                SB.Append(str);
                SB.Append(appendEnd);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(SB.ToString());
                request.Method = "GET";
                request.Headers.Add("X-FullContact-APIKey", "bac349144cb78cde");

                WebResponse response = request.GetResponse();
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                {
                    string content = sr.ReadToEnd();
                    temp = content;
                }
                return temp;
            }



            public static List<Portfolio> JsonData(string z)
            {
                JObject json = JObject.Parse(z);
                JToken newToken2 = json["onlineSince"];
                JToken newToken1 = json["organization"];
                JToken newToken3 = json["traffic"]["topCountryRanking"].First().First();
                Portfolio temp = newToken1.ToObject<Portfolio>();
                temp.onlineSince = newToken2.ToString();
                temp.traffic = newToken3.ToString();
                portfolioList.Add(temp);
                
                
                foreach (Portfolio port in Companyfinder.portfolioList)
                {
                    orgData[0] = temp.name;
                    orgData[1] = temp.founded.ToString();
                    orgData[2] = temp.overview;
                    orgData[3] = temp.approxEmployees;
                    orgData[4] = temp.onlineSince;
                    orgData[5] = temp.traffic;
                }
                
                return portfolioList;
            }
        }
    }
}