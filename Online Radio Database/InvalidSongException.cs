using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Radio_Database
{
    internal class InvalidSongException: Exception
    {
        private string exceptionMessage = "Invalid song.";

        public virtual string ExceptionMessage
        {
            set => this.exceptionMessage = value;
        }

        public override string Message => exceptionMessage;
    }
}
