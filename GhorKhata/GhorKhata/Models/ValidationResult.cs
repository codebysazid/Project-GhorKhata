using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhorKhata.Models
{
    internal class ValidationResult
    {
        public bool IsValid { get; set; }
        public string NameMessage { get; set; }
        public string UsernameMessage { get; set; }
        public string EmailMessage { get; set; }
        public string DOBMessage { get; set; }
        public string GenderMessage { get; set; }
        public string PasswordMessage { get; set; }
        public string ConfirmPasswordMessage { get; set; }
        public string TermsMessage { get; set; }
    }
}
