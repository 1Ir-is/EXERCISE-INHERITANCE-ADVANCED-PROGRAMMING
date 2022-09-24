using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Radio_Database
{
    internal class InvalidSongLengthException: InvalidSongException
    {
        public override string Message => "Invalid song length.";
    }
}
