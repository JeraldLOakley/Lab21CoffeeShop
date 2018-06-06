using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lab21.Models;

namespace Lab21.Controllers
{
    public class ItemsController : Controller
    {
        private ItemIDAO dao = new ItemDAO();

        // GET: Items
        public ActionResult Index()
        {
            return View(dao.GetItemList());
        }

        // GET: Items/Details/5
       

        // GET: Items/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Items/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Description,Quantity,Price")] Item item)
        {
            if (ModelState.IsValid)
            {
                dao.AddItem(item);
                return RedirectToAction("Index");
            }

            return View(item);
        }

        // GET: Items/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = dao.GetItem((int)id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: Items/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Description,Quantity,Price")] Item item)
        {
            if (ModelState.IsValid)
            {
                dao.EditItem(item);
                return RedirectToAction("Index");
            }
            return View(item);
        }
      
        public ActionResult Delete(int id)
        {
            dao.DeleteItem(id);
            return RedirectToAction("Index");
        }

		public ActionResult Menu()
		{
			ViewBag.Items = dao.GetItemList();
			return View();
		}

		public ActionResult MenuSorted(string column)
		{
			CoffeeEntities db = new CoffeeEntities();
			
			if (column == "Name")
			{
				ViewBag.Items = (from i in db.Items
								 orderby i.Name
								 select i).ToList();
			}
			else if (column == "Description")
			{
				ViewBag.Items = (from i in db.Items
								 orderby i.Description
								 select i).ToList();
			}
			else if (column == "Stock")
			{
				ViewBag.Items = (from i in db.Items
								 orderby i.Stock
								 select i).ToList();
			}
			else if (column == "Price")
			{
				ViewBag.Items = (from i in db.Items
								 orderby i.Price
								 select i).ToList();
			}
			return View("Menu");
		}
			public ActionResult Add(int? id)
			{
			CoffeeEntities db = new CoffeeEntities();
				if (Session["Cart"] == null)
				{
					
					List<Item> cart = new List<Item>();
					
					cart.Add((from i in db.Items
							  where i.ID == id
							  select i).Single());
					
					Session.Add("Cart", cart);
				}
				else
				{
					
					List<Item> cart = (List<Item>)(Session["Cart"]);
					
					cart.Add((from i in db.Items
							  where i.ID == id
							  select i).Single());
				}
				return View("Add") ;
			}



		protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dao.Dispose();
            }
            base.Dispose(disposing);
        }



	}
}
