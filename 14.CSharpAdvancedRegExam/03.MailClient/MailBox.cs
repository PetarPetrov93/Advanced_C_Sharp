using System.Text;

namespace MailClient
{
    public class MailBox
    {
        public MailBox(int capacity)
        {
            Capacity = capacity;
            Inbox = new List<Mail>();
            Archive = new List<Mail>();
        }
        public int Capacity { get; set; }
        public List<Mail> Inbox { get; private set; }
        public List<Mail> Archive { get; private set; }

        public void IncomingMail(Mail mail)
        {
            if (Inbox.Count < Capacity)
            {
                Inbox.Add(mail);
            }
        }

        public bool DeleteMail(string sender)
        {
            if (Inbox.Any(x => x.Sender == sender))
            {
                Inbox.RemoveAll(x => x.Sender == sender);
                return true;
            }
            return false;
        }
        
        public int ArchiveInboxMessages()
        {
            Archive.AddRange(Inbox);
            Inbox.Clear();
            return Archive.Count;
        }

        public string GetLongestMessage() => Inbox.OrderByDescending(x => x.Body).First().ToString();

        public string InboxView()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Inbox:");
            foreach (var mail in Inbox)
            {
                sb.AppendLine(mail.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
