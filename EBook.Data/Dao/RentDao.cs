using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace EBook.Data
{
    public class RentDao : SingleKeyDao<Rent, int>
    {
        protected override Expression<Func<Rent, int>> KeySelector => x => x.RentId;

        public List<Rent> GetByCustomerId(int customerId)
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Rents
                            where x.CustomerId == customerId
                            select x;

                return query.ToList();
            }
        }

        public List<Rent> GetByBookId(int bookId)
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Rents
                            where x.BookId == bookId
                            select x;

                return query.ToList();
            }
        }

        public List<Rent> GetByRentDate(DateTime rentDate)
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Rents
                            where x.RentDate == rentDate
                            select x;

                return query.ToList();
            }
        }
















        public List<Summay> Search(int borrow)  //데이터를 리스트화해서 찾는 메소드
        {
            List<Rent> rents = GetWithExtra(borrow); //Rent데이터를 리스트화 한 매개변수를 rents.
                                                     //GetWithExtra라는 메소드에서 생긴 리스트를 rents에 저장.

            List<Summay> models = new List<Summay>();

            foreach (Rent rent in rents)  //Rents에 있는 rent를 돌린다.
            {
                Summay summary = models.Find(x => x.Decade == rent.Decade && x.Genre == rent.Genre);
                //매개변수 summary = models에 있는 리스트를 찾는다.(Find)
                //foreach에서 생성한 매개변수 x에 있는 Decade 값이 Rents에 있는 Decade 값도 동일한지 체크.
                //                                   Genre 값이 Rents에 있는 Genre 값이 동일한지 체크.
                // ex) 10대, 문학(생성) / 10대, 역사(생성) / 20대, 문학(생성) 

                if (summary != null)
                    summary.Count++;
                //summary값이 null아닐 경우 count를 올려줌.

                //null값일 경우
                else
                {
                    summary = new Summay();
                    summary.Count = 1;
                    summary.Decade = rent.Decade;
                    summary.Genre = rent.Genre;

                    models.Add(summary);
                }
                //count = 1, Decade, Genre을 models에 추가(Add).
            }

            return models; //models를 반환함.
        }


        private List<Rent> GetWithExtra(int year) //Search 메소드에서 만든 것 생성.
        {
            using (var context = DbContextCreator.Create())   //MSSQL 사용문
            {
                //쿼리문
                var query = from x in context.Rents                 //x에 Rents 다 불러오기.          
                            where x.RentDate.Year == year           //불러온 것 중에 RentDate를 year에 넣기
                            select new                              //익명객체 생성
                            {
                                Rent = x,
                                Genre = x.Book.Genre,
                                BirthYear = x.Customer.BirthYear
                            };

                var list = query.ToList();                  //시퀀스 요소 리스트화

                foreach (var item in list)                       //리스트에 item이라는 매개변수를 생성해서 돌림.
                {
                    item.Rent.Genre = item.Genre;
                    item.Rent.BirthYear = item.BirthYear;
                }

                return list.Select(x => x.Rent).ToList();   //return list.ConvertAll(x => x.Rent)
                                                            //x라고 이름이 지정되고 x의 Rent값을 반환하는 매개변수를
                                                            //지정하는 람다식을 리스트를 Return으로 반환.
                                                            //list
                                                            //Select(x => x.Rent)
                                                            //ToList
            }
        }

        /* private List<Rent> GetWithExtra2(int year) 
         {
             using (var context = DbContextCreator.Create())
             {

                 Dictionary<int, int> birthyears
                     = context.Customers.ToDictionary(x => x.CustomerId, x => x.BirthYear);

                 Dictionary<int, string> genres = context.Books.ToDictionary(x => x.BookId, x => x.Genre);

                 var query = from x in context.Rents
                             where x.RentDate.Year == year
                             select x;

                 List<Rent> list = query.ToList();

                 foreach(var rent in list)
                 {
                     rent.Genre = genres[rent.BookId];

                     //rent.Genre = genres[1] //1, 역사
                     //rent.Genre = genres[2] //2, 문학

                     rent.BirthYear = birthyears[rent.CustomerId];
                 }

                 return list;
             }
         }*/

        /*private List<Rent> ListCount(int count)
        {
            List<Rent> rents = GetCount(count);

            List<Summay> lists = new List<Summay>();

            foreach (Rent rent in rents)  //Rents에 있는 rent를 돌린다.
            {

                Summay rankList = lists.Count<Summay>(Func<rent.RentAmount>);
                //PopularRankList rankList = lists.Find(x => x.RentAmount == rent.RentAmount);
                //TODO : 내가 하고 싶은 Count확장메소드를 사용하고 싶은건데 오류메시지가 나타남.
                //Count확장메소드를 쓰는 방법은?

                *//*
                                if (rankList != null)
                                    rankList.Count++;

                                else
                                {
                                    rankList = new PopularRankList();
                                    rankList.Count = 1;
                                    rankList.RentAmount = rent.RentAmount;

                                    lists.Add(rankList);
                                }*//*
            }

            return lists;
        }

        private List<Rent> GetCount(int count)
        {
            using (var context = DbContextCreator.Create()) 
            {
                //쿼리문

                //TODO : 교수님께서 익명객체이므로 query2 만드는거 불가능하다고 하셨는데
                        //다른 메소드에서 이름 바꿔야하나요?
                var query = from x in context.Rents
                            where x.BookId == count
                            select new       
                            {
                                Rent = x,
                                RentAmount = x.BookId
                            };

                var list = query.ToList();                

                foreach (var item in list)                      
                {
                    item.Rent.BookId = item.RentAmount;
                }

                return list.Select(x => x.Rent).ToList(); 
                                                           
            }
        }*/




    }
}