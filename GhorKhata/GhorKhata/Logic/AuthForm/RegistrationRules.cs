using GhorKhata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhorKhata.Logic.AuthForm
{
    internal class RegistrationRules
    {
        private RegistrationData data;
        private RegistrationValidationResult result;

        public RegistrationRules(RegistrationData registrationData)
        {
            data = registrationData;
            result = new RegistrationValidationResult();
        }

        public RegistrationValidationResult Validate()
        {
            ValidateName();
            ValidatePhone();
            ValidateEmail();
            ValidateAge();
            ValidateGender();
            ValidatePassword();
            ValidateConfirmPassword();
            ValidateTerms();
            CheckAllConditions();

            return result;
        }

        private void ValidateName()
        {
            if (string.IsNullOrWhiteSpace(data.Name))
            {
                result.NameMessage = "⚠️ Name cannot be empty";
            }
            else if (data.Name.Length < 3)
            {
                result.NameMessage = "⚠️ Name must be at least 3 characters";
            }
            else
            {
                result.NameMessage = "";
            }
        }

        private void ValidatePhone()
        {
            if (string.IsNullOrWhiteSpace(data.Phone))
            {
                result.PhoneMessage = "⚠️ Phone Number cannot be empty";
            }
            else if (data.Phone.Length != 11)
            {
                result.PhoneMessage = "⚠️ Not a valid Phone Number";
            }
            else if (!data.Phone.StartsWith("01"))
            {
                result.PhoneMessage = "⚠️ Not a valid Phone Number";
            }
            else
            {
                result.PhoneMessage = "";
            }
        }

        private void ValidateEmail()
        {
            if (string.IsNullOrWhiteSpace(data.Email))
            {
                result.EmailMessage = "⚠️ Email cannot be empty";
            }
            else if (!data.Email.Contains("@") || !data.Email.Contains("."))
            {
                result.EmailMessage = "⚠️ Invalid email format";
            }
            else
            {
                result.EmailMessage = "";
            }
        }

        private void ValidateAge()
        {
            bool isOfAge = data.DateOfBirth.Date <= DateTime.Today.AddYears(-13);
            if (!isOfAge)
            {
                result.DOBMessage = "⚠️ You must be 13+";
            }
            else
            {
                result.DOBMessage = "";
            }
        }

        private void ValidateGender()
        {
            if (string.IsNullOrWhiteSpace(data.Gender))
            {
                result.GenderMessage = "⚠️ Please select a gender";
            }
            else
            {
                result.GenderMessage = "";
            }
        }

        private void ValidatePassword()
        {
            if (string.IsNullOrWhiteSpace(data.Password))
            {
                result.PasswordMessage = "⚠️ Password cannot be empty";
            }
            else if (data.Password.Length < 6)
            {
                result.PasswordMessage = "⚠️ Password must be 6+ characters";
            }
            else if (!data.Password.Any(char.IsLetter) || !data.Password.Any(char.IsDigit))
            {
                result.PasswordMessage = "⚠️ Use letters and numbers";
            }
            else
            {
                result.PasswordMessage = "✔️ Strong Password";
            }
        }

        private void ValidateConfirmPassword()
        {
            if (string.IsNullOrWhiteSpace(data.ConfirmPassword))
            {
                result.ConfirmPasswordMessage = "";
            }
            else if (data.Password != data.ConfirmPassword)
            {
                result.ConfirmPasswordMessage = "⚠️ Passwords don't match";
            }
            else
            {
                result.ConfirmPasswordMessage = "✔️ Matched";
            }
        }

        private void ValidateTerms()
        {
            if (!data.TermsAccepted)
            {
                result.TermsMessage = "⚠️ You must accept terms";
            }
            else
            {
                result.TermsMessage = "";
            }
        }

        private void CheckAllConditions()
        {
            result.IsValid = string.IsNullOrEmpty(result.NameMessage) &&
                           string.IsNullOrEmpty(result.PhoneMessage) &&
                           string.IsNullOrEmpty(result.EmailMessage) &&
                           string.IsNullOrEmpty(result.DOBMessage) &&
                           string.IsNullOrEmpty(result.GenderMessage) &&
                           result.PasswordMessage == "✔️ Strong Password" &&
                           result.ConfirmPasswordMessage == "✔️ Matched" &&
                           data.TermsAccepted;
        }
    }
}
