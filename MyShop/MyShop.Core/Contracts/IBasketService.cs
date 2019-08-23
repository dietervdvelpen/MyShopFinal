using MyShop.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyShop.Core.Contracts
{
    public interface IBasketService
    {
        public void AddToBasket(HttpContextBase httpContext, string productId);
        public void RemoveFromBasket(HttpContext httpContext, string itemId);
        public List<BasketItemViewModel> GetBasketItems(HttpContextBase httpContext);
        public BasketSummaryViewModel GetBasketSummary(HttpContextBase httpContext);


    }
}
