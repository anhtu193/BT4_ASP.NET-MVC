using BT4_ASP.NET_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BT4_ASP.NET_MVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            QuanLySanPhamDataContext context = new QuanLySanPhamDataContext("Data Source=LAPTOP-H3A07V47;Initial Catalog=QuanLySanPham;Integrated Security=True");
            List<Product> dsProduct = context.Products.ToList();
            return View(dsProduct);
        }
    }
}