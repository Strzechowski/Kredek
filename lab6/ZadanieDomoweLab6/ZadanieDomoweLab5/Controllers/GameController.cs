using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using ZadanieDomoweLab5.Dtos;

namespace ZadanieDomoweLab5.Controllers
{
    [RoutePrefix("api/games")]
    public class GameController : ApiController
    {
        DataClassesRankingDatabaseDataContext context = new DataClassesRankingDatabaseDataContext();
        private List<GameDto> games;

        /// <summary>
        /// Konstruktor inicializujący listę informacji o grach 
        /// </summary>
        GameController()
        {
            MakeAGameList();
        }

        /// <summary>
        /// Funkcja tworzy listę informacji o raningach użytkowników
        /// </summary>
        public void MakeAGameList()
        {
            var query = from G in context.Games
                        join S in context.Statistics on G.StatisticsID equals S.ID
                        select new GameDto()
                        {
                            ID = G.ID,
                            NameOfGame = G.NameOfGame,
                            LevelOfDifficulty = G.LevelOfDifficulty,
                            Stats = new StatisticDto
                            {
                                ID = S.ID,
                                NumberOfViews = S.NumberOfViews,
                                TimeSpendInGame = S.TimeSpendInGame
                            }
                        };

            games = query.ToList<GameDto>();
        }


        /// <summary>
        /// Wyświetla wszystkie gry
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("")]
        [ResponseType(typeof(GameDto))]
        public IHttpActionResult Get()
        {
            return Ok(games);
        }


        /// <summary>
        /// Funkcja wyświetla informacje o wybranej po ID grze 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet, Route("{id:int}", Name = "GetGame")]
        [ResponseType(typeof(GameDto))]
        public IHttpActionResult Get(int id)
        {
            var gam = games.SingleOrDefault(x => x.ID == id);

            if (gam == null)
            {
                return NotFound();
            }
            return Ok(gam);
        }

        /// <summary>
        /// Pozwala dodać nową grę 
        /// </summary>
        /// <param name="gam"></param>
        /// <returns></returns>
        [HttpPost, Route("")]
        public IHttpActionResult Post([FromBody] GameDto gam)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var maxId = games.Max(x => x.ID);
            gam.ID = ++maxId;

            games.Add(gam);

            return CreatedAtRoute("GetGame", new { id = gam.ID }, gam);
        }

        /// <summary>
        /// Funckja służy do edycji rankingu
        /// </summary>
        /// <param name="gameToEdit"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut, Route("{id:int}")]
        public IHttpActionResult Put([FromBody] GameDto gam, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var gameToEdit = games.SingleOrDefault(x => x.ID == id);
            if (gameToEdit == null)
            {
                return NotFound();
            }
            gameToEdit.LevelOfDifficulty = gam.LevelOfDifficulty;
            gameToEdit.NameOfGame = gam.NameOfGame;
            gameToEdit.Stats = gam.Stats;

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
            var gam = games.SingleOrDefault(x => x.ID == id);
            if (gam == null)
            {
                return NotFound();
            }
            games.Remove(gam);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
