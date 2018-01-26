using System;
using System.Xml;

namespace MsgTrans.Library
{
    public class WinerrorCommand : XmlCommand
    {
        public WinerrorCommand(MessageTranslator msgTrans,
                               string winerrorXml)
            : base(msgTrans, winerrorXml)
        {
        }

        public override string[] AvailableCommands
        {
            get { return new string[] { "winerror" }; }
        }

        public override bool Handle(MessageContext context,
                                    string commandName,
                                    string parameters)
        {

            string winerrorText = parameters;
            if (winerrorText.Equals(String.Empty))
            {
                return false;
            }

            long dec;
            string hex;
            NumberParser np = new NumberParser();
            if (np.Parse(winerrorText))
            {
                dec = np.Decimal;
                hex = np.Hex;
            }
            else
            {
                dec = GetNtStatusNumber(winerrorText);
                if (dec == -1)
                {
                    return false;
                }
                hex = dec.ToString("X");
            }

            string description = GetWinerrorDescription(dec);
            if (description != null)
            {
                string message = new System.ComponentModel.Win32Exception(Convert.ToInt32(dec)).Message;

                AddMessage(MessageType.WinError,
                           dec,
                           hex,
                           description,
                           message);

                return true;
            }

            return false;
        }

        public override string Help()
        {
            return "!winerror <value>";
        }
        
        public string GetWinerrorDescription(long winerror)
        {
            XmlElement root = base.m_XmlDocument.DocumentElement;
            XmlNode node = root.SelectSingleNode(String.Format("Winerror[@value='{0}']",
                                                               winerror));
            if (node != null)
            {
                XmlAttribute text = node.Attributes["text"];
                if (text == null)
                    throw new Exception("Node has no text attribute.");
                return text.Value;
            }
            else
                return null;
        }

        private long GetNtStatusNumber(string winerrorName)
        {
            XmlElement root = base.m_XmlDocument.DocumentElement;
            XmlNode node = root.SelectSingleNode(String.Format("Winerror[@text='{0}']",
                                                               winerrorName));
            if (node != null)
            {
                XmlAttribute value = node.Attributes["value"];
                if (value == null)
                    throw new Exception("Node has no value attribute.");

                return Convert.ToInt64(value.Value);
            }
            else
                return -1;
        }
    }
}
