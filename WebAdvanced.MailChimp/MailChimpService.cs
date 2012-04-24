using System;
using System.Collections.Generic;
using System.Linq;
using PerceptiveMCAPI;
using PerceptiveMCAPI.Methods;
using PerceptiveMCAPI.Types;

namespace WebAdvanced.MailChimp {
    public class MailChimpService : IMailChimpService {
        public MailChimpService() {
            DoubleOptin = false;
            ReplaceInterests = true;
            UpdateExisting = false;
        }

        public bool DoubleOptin { get; set; }
        public bool ReplaceInterests { get; set; }
        public bool UpdateExisting { get; set; }
        public string ListId { get; set; }

        #region IMailChimpService Members

        public MailChimpResult Subscribe(Dictionary<string, object> entry, string listId) {
            Check.Argument.IsNotNull(entry, "entry");
            var batch = new List<Dictionary<string, object>> {entry};
            return Subscribe(batch, listId);
        }

        public MailChimpResult Subscribe(string email, string listId) {
            var entry = new Dictionary<string, object> {{"EMAIL", email}};
            var batch = new List<Dictionary<string, object>> {entry};
            return Subscribe(batch, listId);
        }

        public MailChimpResult Subscribe(List<Dictionary<string, object>> batch, string listId) {
            Check.Argument.IsNotNull(batch, "batch");
            Check.Argument.IsNotNullOrEmpty(listId, "listId");
            var input = new listBatchSubscribeInput
                        {
                            api_Validate = true,
                            api_AccessType = EnumValues.AccessType.Serial,
                            api_OutputType = EnumValues.OutputType.JSON,
                            parms =
                                {
                                    apikey = MailChimpConfiguration.ApiKey,
                                    id = listId,
                                    double_optin = DoubleOptin,
                                    replace_interests = ReplaceInterests,
                                    update_existing = UpdateExisting,
                                    batch = batch
                                },
                        };
            var cmd = new listBatchSubscribe(input);
            listBatchSubscribeOutput output = cmd.Execute();
            return new MailChimpResult(output.api_ErrorMessages.Count <= 0, output.api_ErrorMessages);
        }

        public bool IsSubscribed(string email, string listId) {
            listsForEmailOutput list = new listsForEmail(new listsForEmailInput(MailChimpConfiguration.ApiKey, email)).Execute();
            return list.result.Any(id => listId.Equals(id, StringComparison.InvariantCultureIgnoreCase));
        }

        #endregion
    }
}