using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using ZadanieDomoweLab5.Dtos;

namespace ZadanieDomoweLab5.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersInfoController : ApiController
    {
        static DataClassesRankingDatabaseDataContext context = new DataClassesRankingDatabaseDataContext();
        private static readonly List<UserInfoDto> users;

        /// <summary>
        /// Konstruktor inicializujący listę informacji o użytkownikach
        /// </summary>
        static UsersInfoController()
        {
            var query = from U in context.UserInfos
                        select new UserInfoDto()
                        {
                            ID = U.ID,
                            FirstName = U.FirstName,
                            Surname = U.Surname,
                            EyeColor = U.EyeColor,
                            FavouriteAnimal = U.FavouriteAnimal
                        };

             users = query.ToList<UserInfoDto>();
        }

        /// <summary>
        /// Funkcja zwraca wszyskie informacje o użytkownikach
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("")]
        [ResponseType(typeof(UserInfoDto))]
        public IHttpActionResult Get()
        {
            return Ok(users);
        }

        /// <summary>
        /// Funkcja wyświetla informacje o konkretnym użytkowniku
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet, Route("{id:int}", Name = "GetUser")]
        [ResponseType(typeof(UserInfoDto))]
        public IHttpActionResult Get(int id)
        {
            var user = users.SingleOrDefault(x => x.ID == id);

            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        /// <summary>
        /// Pozwala dodać nowego użytkownika
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost, Route("")]
        public IHttpActionResult Post([FromBody] UserInfoDto user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var maxId = users.Max(x => x.ID);
            user.ID = ++maxId;

            users.Add(user);

            return CreatedAtRoute("GetUser", new { id = user.ID }, user);
        }

        /// <summary>
        /// Funckja służy do edycji użytkownika
        /// </summary>
        /// <param name="user"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut, Route("{id:int}")]
        public IHttpActionResult Put([FromBody] UserInfoDto user, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var userToEdit = users.SingleOrDefault(x => x.ID == id);
            if (userToEdit == null)
            {
                return NotFound();
            }
            userToEdit.FirstName = user.FirstName;
            userToEdit.Surname = user.Surname;
            userToEdit.FavouriteAnimal = user.FavouriteAnimal;
            userToEdit.EyeColor = user.EyeColor;

            return StatusCode(HttpStatusCode.NoContent);
        }

        /// <summary>
        /// Służy do usuwania wskazanego użytkownika
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete, Route("{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            var user = users.SingleOrDefault(x => x.ID == id);
            if (user == null)
            {
                return NotFound();
            }
            users.Remove(user);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }

}
