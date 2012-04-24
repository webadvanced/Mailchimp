using System.Collections.Generic;
using PerceptiveMCAPI.Types;

namespace WebAdvanced.MailChimp {
    public class MailChimpResult {
        public MailChimpResult() {
        }

        public MailChimpResult(bool success, List<Api_Error> errors = null) {
            Success = success;
            Errors = errors;
        }
        public bool Success { get; set; }
        public List<Api_Error> Errors { get; set; }
    }
}