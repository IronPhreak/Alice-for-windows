using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Xml;

namespace Alice_For_Windows
{
    internal class Web
    {
        public static string rssReader(string url)
        {
            try
            {
                XmlReader reader = XmlReader.Create(url);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();
                List<string> subjects = new List<string>();
                foreach (SyndicationItem item in feed.Items)
                {
                    subjects.Add(item.Title.Text);
                }
                return subjects[0];
            }
            catch
            {
            }
            return ("No feed");
        }
    }
}