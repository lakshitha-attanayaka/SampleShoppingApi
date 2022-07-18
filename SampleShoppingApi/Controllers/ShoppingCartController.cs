using Microsoft.AspNetCore.Mvc;
using SampleShoppingApi.Models;
using System.Linq;

namespace SampleShoppingApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ShoppingCartController : Controller
    {
        private ShoppingCart _baduMalla;
        private Aisle _aisle;
        public ShoppingCartController()
        {
            _aisle = new Aisle();
            _aisle.Type = "Grosery";
            ShoppingItem item1 = new ShoppingItem();
            ShoppingItem item2 = new ShoppingItem();
            ShoppingItem item3 = new ShoppingItem();
            item1.Name = "Baby Saban";
            item1.Price = 200.00;
            item1.Code = 123;
            item1.Description = "Babage Sudu hamata hoda saban";
            item1.Image = "https://backend.lassana.com/images//products/Panda%20Baby%20-%20Delum%20Baby%20Soap%20%2075%20g--1627968441.jpg";


            item2.Name = "Cream Cracker";
            item2.Price = 420.00;
            item2.Code = 456;
            item2.Description = "Thattu 7 biscut eka";
            item2.Image = "https://cdn.shopify.com/s/files/1/2671/1426/products/Maliban-Smart-Cream-Cracker-_Large-Pack_-500g_438x438.jpg?v=1558279762";
            
            item3.Name = "Pol Thel";
            item3.Price = 820.00;
            item3.Code = 789;
            item3.Description = "Lankawe hidu pirisidu pol thel";
            item3.Image = "https://i1.wp.com/www.navalanka.lk/wp-content/uploads/2018/08/00025164.jpg?fit=250%2C300&ssl=1";


            _aisle.Items.Add(item1);
            _aisle.Items.Add(item2);
            _aisle.Items.Add(item3);

            _baduMalla = new ShoppingCart();
            _baduMalla.Items.Add(item1);
            _baduMalla.Items.Add(item2);
            _baduMalla.Items.Add(item3);

            _baduMalla.TotalPrice = _baduMalla.Items.Sum(s => s.Price);
            _baduMalla.CustomerName = "Iresh";
            _baduMalla.NumberOfItems = _baduMalla.Items.Count;
        }

        [HttpGet]
        public ShoppingCart Get()
        {
            return _baduMalla;
        }

        [HttpGet("{code}", Name = "GetItem")]
        public ShoppingItem GetItem(int code)
        {
            return _aisle.Items.Where(item => item.Code == code).First();
            
        }

    }
}
