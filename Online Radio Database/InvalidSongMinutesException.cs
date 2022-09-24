using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Radio_Database
{
    internal class InvalidSongMinutesException: InvalidSongLengthException
    {
        private const int MinMinutesValue = 0;
        private const int MaxMinutesValue = 14;

        public override string Message => $"Song minutes should be between {MinMinutesValue} and {MaxMinutesValue}.";
    }
}
