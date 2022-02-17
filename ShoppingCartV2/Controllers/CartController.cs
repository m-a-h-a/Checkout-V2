using Microsoft.AspNetCore.Mvc;
using ShoppingCartV2.Interfaces;
using ShoppingCartV2.Models;

namespace ShoppingCartV2.Controllers
{
    [ApiController]
    [Route("controller")]
    public class CartController : Controller
    {
        private readonly IDiscountCalculator _discountCalculator;
        private readonly ISubTotalCalculator _subTotalCalculator;
        private readonly IOffersText _offersText;

        public CartController(IDiscountCalculator discountCalculator, ISubTotalCalculator subTotal, IOffersText offersText)
        {
            _discountCalculator = discountCalculator;
            _subTotalCalculator = subTotal;
            _offersText = offersText;
        }

        [HttpGet]
        public CheckoutModel Get(string shoppingCart)
        {
            var discountCalc = _discountCalculator.GetCalculateDiscount;
            var subTotal = _subTotalCalculator.GatherSubTotal;
            var offersText = _offersText.CreateOffersText;

            CheckoutModel checkoutModel = new CheckoutModel()
            {
                CartContents = shoppingCart,
                Subtotal = subTotal(shoppingCart),
                DiscountApplied = discountCalc(shoppingCart),
                OffersAppliedText = offersText(shoppingCart),
                CheckoutTotal = subTotal(shoppingCart) - discountCalc(shoppingCart)
            };

            if (shoppingCart == null) { return checkoutModel; }

            return checkoutModel;
        }
    }
}
