using Microsoft.AspNetCore.Mvc;
using ShoppingCartV2.Models;

namespace ShoppingCartV2.Controllers
{
    [ApiController]
    [Route("controller")]
    public class CartController : Controller
    {
        private OffersText _offersText;
        private GetSubTotal _subTotal;
        private GetDiscount _discounts;

        [HttpGet]
        public CheckoutModel Get(string shoppingCart)
        {
            _subTotal = new GetSubTotal();
            _discounts = new GetDiscount();
            _offersText = new OffersText();

            CheckoutModel checkoutModel = new CheckoutModel()
            {
                CartContents = shoppingCart,
                Subtotal = _subTotal.GatherSubTotal(shoppingCart),
                DiscountApplied = _discounts.GetCalculateDiscount(shoppingCart),
                OffersAppliedText = _offersText.CreateOffersText(shoppingCart),
                CheckoutTotal = _subTotal.GatherSubTotal(shoppingCart) - _discounts.GetCalculateDiscount(shoppingCart)
            };

            if (shoppingCart == null) { return checkoutModel; }

            return checkoutModel;
        }
    }
}
