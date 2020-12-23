using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using EBook.Data.Models;

namespace EBook.Data
{
    public class RentDao : SingleKeyDao<Rent, int>
    {
        protected override Expression<Func<Rent, int>> KeySelector => x => x.RentId;
        
        /// <summary>
        /// 연령별로 장르 구분하는 메소드
        /// </summary>
        /// <param name="borrow"></param>
        /// <returns></returns>
        public List<DecadeExtraSummary> DecadeGenreSearch(int borrow)  //데이터를 리스트화해서 찾는 메소드
        {
            List<Rent> rents = GetWithDecadeGenre(borrow); //Rent데이터를 리스트화 한 매개변수를 rents.
                                                     //GetWithExtra라는 메소드에서 생긴 리스트를 rents에 저장.

            List<DecadeExtraSummary> models = new List<DecadeExtraSummary>();

            foreach (Rent rent in rents)  //Rents에 있는 rent를 돌린다.
            {
                DecadeExtraSummary summary = models.Find(x => x.Decade == rent.Decade && x.Genre == rent.Genre);
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
                    summary = new DecadeExtraSummary();
                    summary.Count = 1;
                    summary.Decade = rent.Decade;
                    summary.Genre = rent.Genre;

                    models.Add(summary);
                }
                //count = 1, Decade, Genre을 models에 추가(Add).
            }

            return models; //models를 반환함.
        }



        private List<Rent> GetWithDecadeGenre(int year) //Search 메소드에서 만든 것 생성.
        {
            using (var context = DbContextCreator.Create())   //MSSQL 사용문
            {
                DateTime firstDay = new DateTime(year, 1, 1);
                DateTime lastDay = new DateTime(year, 12, 31);

                //쿼리문
                var query = from x in context.Rents                 //x에 Rents 다 불러오기.          
                            where x.RentDate >= firstDay && x.RentDate <= lastDay 
                                //where x.RentDate.Year == year
                                //RentDate 중에서 Year만 추출.
                                //sql에서 인식하지 않는 코드.
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

        /* private List<Rent> GetWithDecadeGenre2(int year) 
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

        /// <summary>
        /// 연령별로 성별 리스트화 메소드
        /// </summary>
        /// <param name="borrow"></param>
        /// <returns></returns>
        public List<DecadeExtraSummary> DecadeGenderSearch(string borrow)
        {
            List<Rent> rents = GetWithDecadeGender(borrow);

            List<DecadeExtraSummary> models = new List<DecadeExtraSummary>();

            foreach (Rent rent in rents)
            {
                DecadeExtraSummary summary = models.Find(x => x.Decade == rent.Decade && x.Gender == rent.Gender);

                if (summary != null)
                    summary.Count++;

                else
                {
                    summary = new DecadeExtraSummary();
                    summary.Count = 1;
                    summary.Decade = rent.Decade;
                    summary.Gender = rent.Gender;

                    models.Add(summary);
                }

            }

            return models; //models를 반환함.
        }
        private List<Rent> GetWithDecadeGender(string gender)
        {
            using (var context = DbContextCreator.Create())
            {

                Dictionary<int, int> birthyears
                     = context.Customers.ToDictionary(x => x.CustomerId, x => x.BirthYear);

                Dictionary<int, string> genders = context.Customers.ToDictionary(x => x.CustomerId, x => x.Gender);


                var query = from x in context.Rents
                            select x;


                List<Rent> list = query.ToList();

                foreach (var rent in list)
                {
                    rent.Gender = genders[rent.CustomerId];
                }

                return list;
            }
        }



        /// <summary>
        /// 시간당 체크 데이터 리스트 메소드
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        public List<PeriodSummary> DaySearch(DateTime day)
        {
            using (var context = DbContextCreator.Create())
            {
                DateTime @from = day.Date;          //자정으로 임의의 날짜를 만듦. from은 키워드이기때문에 '@'가 들어간다.
                DateTime to = from.AddDays(1);      //임의의 날짜 다음날(자정).

                var query = from x in context.Rents
                                //where x.RentDate >= @from && x.RentDate < to 
                            select x;               //하루동안의 렌트 기록을 뽑는다.

                var list = query.ToList();          //리스트로 만들기.

                // RentedOn
                var query2 = from x in list
                             group x by x.RentDate.Hour into HourGroup          //리스트를 모아 한 그룹을 g라고 한다.
                             //select new ThePeriod { Hour = g.Key, Count = g.Count()};
                             select HourGroup;

                //return query2.ToList();

                List<PeriodSummary> periods = new List<PeriodSummary>();
                foreach (var g in query2)
                {
                    PeriodSummary period = new PeriodSummary();
                    period.Value = g.Key;                                //렌트기록중에 '시'만 뽑는다.
                    period.Count = g.Count();                           //ex) 2020.12.18. 14:58:12에 대여기록이 있다면 '14'

                    periods.Add(period);
                }

                return periods;
            }
        }


        public object WeekSearch(DateTime week)
        {
            throw new NotImplementedException();
        }












        /// <summary>
        /// 대여량을 기준으로 베스트셀러 카운트.
        /// </summary>
        /// <returns></returns>
        public List<RankSummary> BestsellerRank()
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Books
                            let bestsellerCount = x.Rents.Count()
                            orderby bestsellerCount descending
                            select new 
                            {
                                Title = x.Title,
                                BestSellerCount = bestsellerCount
                            };

                var list = query.Take(10).ToList();

                return list.ConvertAll(x => new RankSummary { Title = x.Title, BestsellerRank = x.BestSellerCount});
            }
        }


        public List<RankSummary> NewBookRank()
        {
            DateTime firstDay = DateTime.Today.AddMonths(-3);
            DateTime lastDay = DateTime.Today; //Time으로 돌렸다가 다시 Today설정.


            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Books
                            where x.PublicationDate >= firstDay && x.PublicationDate <= lastDay
                            let newBookCount = x.Rents.Count()
                            orderby newBookCount descending
                            select new
                            {
                                Title = x.Title,
                                NewBookCount = newBookCount
                            };

                var list = query.Take(10).ToList();

                return list.ConvertAll(x => new RankSummary { Title = x.Title, NewBookRank = x.NewBookCount });
            }
           
            
        }














        //선택한 날을 포함한 주.
        /*public object WeekSearch(DateTime week)
        {
            using (var context = DbContextCreator.Create())
            {
                DateTime startWeek = DateTime

                var query = from x in context.Rents
                                //where x.RentDate >= @from && x.RentDate < to 
                            select x;               //하루동안의 렌트 기록을 뽑는다.

                var list = query.ToList();          //리스트로 만들기.

                // RentedOn
                var query2 = from x in list
                             group x by x.RentDate.Hour into HourGroup          //리스트를 모아 한 그룹을 g라고 한다.
                             //select new ThePeriod { Hour = g.Key, Count = g.Count()};
                             select HourGroup;

                //return query2.ToList();

                List<PeriodSummary> periods = new List<PeriodSummary>();
                foreach (var g in query2)
                {
                    PeriodSummary period = new PeriodSummary();
                    period.Value = g.Key;                                //렌트기록중에 '시'만 뽑는다.
                    period.Count = g.Count();                           //ex) 2020.12.18. 14:58:12에 대여기록이 있다면 '14'

                    periods.Add(period);
                }

                return periods;
            }
        }*/

    }
}
