using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace WebAdvanced.MailChimp {
    public class MailChimpListCollection : IEnumerable<MailChimpList> {
        private readonly IList<MailChimpList> _mailChimpLists;

        public MailChimpListCollection() {
            _mailChimpLists = new List<MailChimpList>();
        }
        public void Add(MailChimpList list) {
            Check.Argument.IsNotNull(list, "list");
            _mailChimpLists.Add(list);
        }

        public string Key(Func<MailChimpList, bool> func) {
            return _mailChimpLists.Where(func).Select(x => x.Key).First();
        }
        public IEnumerator<MailChimpList> GetEnumerator() {
            return _mailChimpLists.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}