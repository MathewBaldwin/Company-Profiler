namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public class Portfolio
        {
            public string name { get; set; }
            public string overview { get; set; }
            public string approxEmployees { get; set; }
            public int founded { get; set; }
            public string onlineSince { get; set; }
            public string traffic { get; set; }
        }
    }
}