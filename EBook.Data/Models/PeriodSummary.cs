using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBook.Data.Models
{
    public class PeriodSummary
    {
        public int Value { get; set; }

        public int Count { get; set; }

        public string TimeZone          //시간대 지정하는 소스 힌트
        {
            get
            {
                if (Value < 6)
                    return "새벽";
                else
                    return "";
            }
        }
    }
}
