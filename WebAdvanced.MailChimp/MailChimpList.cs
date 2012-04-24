namespace WebAdvanced.MailChimp {
    public class MailChimpList {
        public MailChimpList(string name, string key) {
            Check.Argument.IsNotNullOrEmpty(name, "name");
            Check.Argument.IsNotNullOrEmpty(key, "key");
            Name = name;
            Key = key;
        }

        public string Name { get; private set; }
        public string Key { get; private set; }
    }
}