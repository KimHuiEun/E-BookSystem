using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBook.Data
{
    public partial class Rent
    {
        public override string ToString()
        {
            return $"{RentId} / {RentDate} / {CustomerId} / {BookId} / {ReturnedDate}";
        }

        public int Decade
        {
            get
            {
                return (DateTime.Now.Year - BirthYear) / 10 * 10;
            }
        }

        //TODO : 메소드 생성의 필요성 어디까지. 
        //          -> 대여량 집계로 조건 달아서 할 수 있는지. 메소드(베스트셀러,신간)로 랭크를 하나씩 만들어야하는지


        
        //TODO : 책 당 대여량을 구해야하는 것이므로 책을 정렬 한 후 그 책에 따른 렌트아이디를 정렬해서 순위를 부여.
                 //-> 쿼리를 써서 리스트를 만드는것.


        public int BirthYear { get; set; }

        public string Genre { get; set; }

        public string Gender { get; set; }
    }

}
