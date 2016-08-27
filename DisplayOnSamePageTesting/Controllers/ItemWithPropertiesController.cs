using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DisplayOnSamePageTesting.Models;
using Newtonsoft.Json;

namespace DisplayOnSamePageTesting.Controllers
{
    public class ItemWithPropertiesController : Controller
    {
        private DisplayContext db = new DisplayContext();

        // GET: ItemWithProperties
        public ActionResult Index(int? itemID)
        {
            PopulateOrganizationsDropDownList();
            if (itemID == null)
                return View();
            else
                return View(db.Items.SingleOrDefault(i => i.Id == itemID.Value));
        }

        public ActionResult AJAXIndex()
        {
            PopulateOrganizationsDropDownList();
            return View();
        }

        private void PopulateOrganizationsDropDownList(int? selectedItem = 1)
        {
            var itemQuery = from r in db.Items
                                     orderby r.Name
                                     select r;
            ViewBag.ItemId = new SelectList(itemQuery, "Id", "Name", selectedItem);
        }

        public JsonResult GetItem(int id)
        {
            var item = db.Items.SingleOrDefault(i => i.Id == id);
            //string json = JsonConvert.SerializeObject(item);
            JsonResult json = new JsonResult
            {
                Data = item,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
            return json;
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
