using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class CurrentDate : ICurrentDate
    {
        public DateTime GetDate()
        {
            return DateTime.Now;
        }
    }
}
