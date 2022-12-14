using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Radio_Database
{
    internal class InvalidSongNameException:InvalidSongException
    {
        private const int MinNameLength = 3;
        private const int MaxNameLength = 30;

        public override string Message => $"Song name should be between {MinNameLength} and {MaxNameLength} symbols.";
    }
}
