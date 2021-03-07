using Common.Resources.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Validations
{
    public static class ErrorSpam
    {
        public static Exception ThrowInvalidName()
        {
            return new ArgumentException(Errors.InvalidName);
        }
        public static Exception ThrowInvalidEmail()
        {
            return new ArgumentException(Errors.InvalidEmail);
        }
        public static Exception ThrowInvalidPhone()
        {
            return new ArgumentException(Errors.InvalidPhone);
        }
        public static Exception ThrowInvalidAddress()
        {
            return new ArgumentException(Errors.InvalidAddress);
        }
        public static Exception ThrowNotFound()
        {
            return new ArgumentException(Errors.NotFound);
        }
        public static Exception ThrowDuplicated()
        {
            return new ArgumentException(Errors.DuplicatedItem);
        }
        public static Exception ThrowInvalidContact()
        {
            return new ArgumentException(Errors.InvalidContact);
        }
    }
}
