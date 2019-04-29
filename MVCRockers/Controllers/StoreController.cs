using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRockers.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.browse(), genre = " + genre);
            return message;
        }

        public string Browse()
        {
            return "Hello from store.Browse()";
        }

        public string Details()
        {
            return "Hello from store.Details()";
        }
    }
}