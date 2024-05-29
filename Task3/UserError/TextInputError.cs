using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.UserError;

internal class TextInputError : UserError
{
    internal override string UEMessage()
    {
        return "You tried to use a text input in a numeric only field. This fired an error!";
    }
}
