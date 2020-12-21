using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBook.Data.Models
{
    public enum TimeUnit  //기간을 계산하기 위한 단위열거형 -> value를 위해
    {
        Month,
        Week,
        Day
    }

    public class PeriodSummary
    {
        public int Value { get; set; } //hours, days, months 함축형

        public int Count { get; set; }

        public TimeUnit Unit { get; set; } //열거형 데이터 프로퍼티

       /* public string PeriodType          //시간대 지정하는 소스 힌트
        {
            get
            {
                if (Unit == TimeUnit.Day)
                {
                    if (Value > 0 && Value <= 3)
                        return "3시";
                    if (Value > 3 && Value <= 6)
                        return "6시";

                    else
                        return "";

                 
                }
                else if (Unit == TimeUnit.Week)
                {

                }
                else if (Unit == TimeUnit.Month)
                {

                }
                
            }
        }
*/
        public string Genre { get; set; }
    }
}
