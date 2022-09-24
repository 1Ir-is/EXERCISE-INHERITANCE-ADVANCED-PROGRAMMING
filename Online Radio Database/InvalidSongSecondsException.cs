using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Radio_Database
{
    internal class InvalidSongSecondsException:InvalidSongLengthException
    {
        private const int MinSecondsValue = 0;
        private const int MazSecondsValue = 59;

        public override string Message => $"Song seconds should be between {MinSecondsValue} and {MazSecondsValue}.";
    }
}
