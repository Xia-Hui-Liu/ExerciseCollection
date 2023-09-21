using System;

namespace ExerciseCollection
{
    internal abstract class UserError
    {
        public UserError()
        {
        }

        public virtual string UEMessage()
        {
            return "message";
        }
    }

    internal class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }

    internal class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }

    internal class CustomError1: UserError
    {
         public override string UEMessage()
        {
            return "This is the first custom error";
        }
    }

      internal class CustomError2: UserError
    {
         public override string UEMessage()
        {
            return "This is the second custom error";
        }
    }

      internal class CustomError3: UserError
    {
         public override string UEMessage()
        {
            return "This is the third custom error";
        }
    }
}
