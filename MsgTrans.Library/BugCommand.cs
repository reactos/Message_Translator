using System;
using Newtonsoft.Json.Linq;

//
// REST API docs
// https://docs.atlassian.com/DAC/rest/jira/6.1.html#d2e1164
//


namespace MsgTrans.Library
{
    public class BugCommand : Command
    {
        string bugUrlFormat;
        string RestUrlFormat = "https://jira.reactos.org/rest/api/2/issue/{0}?fields=summary,reporter,assignee,status,resolution,description";

        string bugUrl;
        string summary;
        string reporter;
        string assignee;
        string status;
        string resolution;
        string description;

        #region properties
        public string Summary
        {
            get { return summary; }
        }
        public string Reporter
        {
            get { return reporter; }
        }
        public string Assignee
        {
            get { return assignee; }
        }
        public string Status
        {
            get { return status; }
        }
        public string Resolution
        {
            get { return resolution; }
        }
        public string Description
        {
            get { return description; }
        }
        public string BugUrl
        {
            get { return bugUrl; }
        }
        #endregion

        public BugCommand(MessageTranslator msgTrans,
                          string bugUrlFormat)
            : base(msgTrans)
        {
            this.bugUrlFormat = bugUrlFormat;
        }

        public override string[] AvailableCommands
        {
            get { return new string[] { "bug" }; }
        }

        public override bool Handle(MessageContext context,
                                    string commandName,
                                    string parameters)
        {
            try
            {
                var client = new System.Net.WebClient();
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

                string RestUrl = String.Format(RestUrlFormat, parameters);
                var response = client.DownloadString(RestUrl);

                bugUrl = String.Format(bugUrlFormat, parameters);

                var json = JObject.Parse(response);
                summary = json["fields"]["summary"].ToString();
                reporter = json["fields"]["reporter"]["displayName"].ToString();
                assignee = json["fields"]["assignee"]["displayName"].ToString();
                status = json["fields"]["status"]["name"].ToString();
                if (json["fields"]["resolution"].HasValues)
                {
                    resolution = json["fields"]["resolution"]["name"].ToString();
                }
                else
                {
                    resolution = "Unresolved";
                }
                description = json["fields"]["description"].ToString();

                MsgType = MessageType.BugUrl;
                MsgTrans.Messages.Add(this);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
