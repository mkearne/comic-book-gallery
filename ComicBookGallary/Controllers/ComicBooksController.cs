using ComicBookGallary.Data;
using ComicBookGallary.Models;
using System.Web.Mvc;

namespace ComicBookGallary.Controllers
{
    public class ComicBooksController : System.Web.Mvc.Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook((int)id);

            return View(comicBook);

        }
          
    }
}