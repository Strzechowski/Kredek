using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using ZadanieDomoweLab5.Dtos;

namespace ZadanieDomoweLab5.Controllers
{
    [RoutePrefix("api/ranking")]
    public class PersonalRankingController : ApiController
    {
        static DataClassesRankingDatabaseDataContext context = new DataClassesRankingDatabaseDataContext();
        private static readonly List<PersonalRankingDto> personalRankings;

        /// <summary>
        /// Konstruktor inicializujący listę informacji o rankinkach użytkowników 
        /// </summary>
        static PersonalRankingController()
        {
            var query = from P in context.PersonalRankings
                        join U in context.UserInfos on P.UserID equals U.ID
                        select new PersonalRankingDto()
                        {
                            ID = P.ID,
                            Score = P.Score,
                            User = new UserInfoDto
                            {
                                ID = U.ID,
                                FirstName = U.FirstName,
                                Surname = U.Surname,
                                EyeColor = U.EyeColor,
                                FavouriteAnimal = U.FavouriteAnimal
                            }
                        };

            personalRankings = query.ToList<PersonalRankingDto>();
        }

        /// <summary>
        /// Wyświetla wszystkie rankingi
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("")]
        [ResponseType(typeof(PersonalRankingDto))]
        public IHttpActionResult Get()
        {
            return Ok(personalRankings);
        }

        /// <summary>
        /// Funkcja wyświetla informacje o wybranym po ID rankingu 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet, Route("{id:int}", Name = "GetRanking")]
        [ResponseType(typeof(PersonalRankingDto))]
        public IHttpActionResult Get(int id)
        {
            var personalRank = personalRankings.SingleOrDefault(x => x.ID == id);

            if (personalRank == null)
            {
                return NotFound();
            }
            return Ok(personalRank);
        }

        /// <summary>
        /// Pozwala dodać nowy ranking 
        /// </summary>
        /// <param name="personalRank"></param>
        /// <returns></returns>
        [HttpPost, Route("")]
        public IHttpActionResult Post([FromBody] PersonalRankingDto personalRank)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var maxId = personalRankings.Max(x => x.ID);
            personalRank.ID = ++maxId;

            personalRankings.Add(personalRank);

            return CreatedAtRoute("GetRanking", new { id = personalRank.ID }, personalRank);
        }

        /// <summary>
        /// Funckja służy do edycji rankingu
        /// </summary>
        /// <param name="rankingToEdit"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut, Route("{id:int}")]
        public IHttpActionResult Put([FromBody] PersonalRankingDto personalRank, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var rankingToEdit = personalRankings.SingleOrDefault(x => x.ID == id);
            if (rankingToEdit == null)
            {
                return NotFound();
            }
            rankingToEdit.Score = personalRank.Score;
            rankingToEdit.User = personalRank.User;

            return StatusCode(HttpStatusCode.NoContent);
        }

        /// <summary>
        /// Służy do usuwania wskazanego rankingu
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete, Route("{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            var personalRank = personalRankings.SingleOrDefault(x => x.ID == id);
            if (personalRank == null)
            {
                return NotFound();
            }
            personalRankings.Remove(personalRank);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
