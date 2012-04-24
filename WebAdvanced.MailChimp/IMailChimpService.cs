using System.Collections.Generic;

namespace WebAdvanced.MailChimp {
    public interface IMailChimpService {
        MailChimpResult Subscribe(List<Dictionary<string, object>> batch, string listId);
        MailChimpResult Subscribe(Dictionary<string, object> entry, string listId);
        MailChimpResult Subscribe(string email, string listId);
        bool IsSubscribed(string email, string listId);
    }
}