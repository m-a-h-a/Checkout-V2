using NUnit.Framework;
using ShoppingCartV2;
using ShoppingCartV2.Controllers;
using ShoppingCartV2.Models;
using FluentAssertions;
using ShoppingCartV2.Interfaces;
using Moq;

namespace ShoppingCartV2_Tests
{
    public class Tests
    {
        private CartController _cartController;
        private IDiscountCalculator _discountCalculator;
        private ISubTotalCalculator _subTotalCalculator;
        private IOffersText _offersText;

        [SetUp]
        public void Setup()
        {
            _discountCalculator = new GetDiscount();
            _subTotalCalculator = new GetSubTotal();
            _offersText = new OffersText();
            _cartController = new CartController(_discountCalculator, _subTotalCalculator, _offersText);
        }

        [TestCase("")]
        public void GivenBlank_ShouldReturnSubTotalOf0DiscountOf0(string receivedItems)
        {
            //arrange
            CheckoutModel checkoutModel = new CheckoutModel()
            {
                CartContents = receivedItems,
                Subtotal = 0,
                DiscountApplied = 0,
                OffersAppliedText = "No Offers Applied.",
                CheckoutTotal = 0 - 0
            };

            //act
            var result = _cartController.Get(receivedItems);

            //assert
            result.Subtotal.Should().Be(checkoutModel.Subtotal);
            result.DiscountApplied.Should().Be(checkoutModel.DiscountApplied);
            result.OffersAppliedText.Should().Be(checkoutModel.OffersAppliedText);
            result.CheckoutTotal.Should().Be(checkoutModel.CheckoutTotal);
            //result.Should().Be(checkoutModel);
        }

        [TestCase("a")]
        public void GivenA_ShouldReturnSubTotalOf50DiscountOf0(string receivedItems)
        {
            //arrange
            CheckoutModel checkoutModel = new CheckoutModel()
            {
                CartContents = receivedItems,
                Subtotal = 50,
                DiscountApplied = 0,
                OffersAppliedText = "No Offers Applied.",
                CheckoutTotal = 50 - 0
            };

            //act
            var result = _cartController.Get(receivedItems);

            //assert
            result.Subtotal.Should().Be(checkoutModel.Subtotal);
            result.DiscountApplied.Should().Be(checkoutModel.DiscountApplied);
            result.OffersAppliedText.Should().Be(checkoutModel.OffersAppliedText);
            result.CheckoutTotal.Should().Be(checkoutModel.CheckoutTotal);
        }

        [TestCase("AA")]
        public void GivenAA_ShouldReturnSubTotalOf100DiscountOf0(string receivedItems)
        {
            //arrange
            CheckoutModel checkoutModel = new CheckoutModel()
            {
                CartContents = receivedItems,
                Subtotal = 100,
                DiscountApplied = 0,
                OffersAppliedText = "No Offers Applied.",
                CheckoutTotal = 100 - 0
            };

            //act
            var result = _cartController.Get(receivedItems);

            //assert
            result.Subtotal.Should().Be(checkoutModel.Subtotal);
            result.DiscountApplied.Should().Be(checkoutModel.DiscountApplied);
            result.OffersAppliedText.Should().Be(checkoutModel.OffersAppliedText);
            result.CheckoutTotal.Should().Be(checkoutModel.CheckoutTotal);
        }

        [TestCase("aaa")]
        public void GivenAAA_ShouldReturnSubTotalOf150DiscountOf20(string receivedItems)
        {
            //arrange
            CheckoutModel checkoutModel = new CheckoutModel()
            {
                CartContents = receivedItems,
                Subtotal = 150,
                DiscountApplied = 20,
                OffersAppliedText = "Item A Offer: Buy 3 for 130\n",
                CheckoutTotal = 150 - 20
            };

            //act
            var result = _cartController.Get(receivedItems);

            //assert
            result.Subtotal.Should().Be(checkoutModel.Subtotal);
            result.DiscountApplied.Should().Be(checkoutModel.DiscountApplied);
            result.OffersAppliedText.Should().Be(checkoutModel.OffersAppliedText);
            result.CheckoutTotal.Should().Be(checkoutModel.CheckoutTotal);
        }

        [TestCase("aaaa")]
        public void GivenAAAA_ShouldReturnSubTotalOf200DiscountOf20(string receivedItems)
        {
            //arrange
            CheckoutModel checkoutModel = new CheckoutModel()
            {
                CartContents = receivedItems,
                Subtotal = 200,
                DiscountApplied = 20,
                OffersAppliedText = "Item A Offer: Buy 3 for 130\n",
                CheckoutTotal = 200 - 20
            };

            //act
            var result = _cartController.Get(receivedItems);

            //assert
            result.Subtotal.Should().Be(checkoutModel.Subtotal);
            result.DiscountApplied.Should().Be(checkoutModel.DiscountApplied);
            result.OffersAppliedText.Should().Be(checkoutModel.OffersAppliedText);
            result.CheckoutTotal.Should().Be(checkoutModel.CheckoutTotal);
        }

        [TestCase("B")]
        public void GivenB_ShouldReturnSubTotalOf30DiscountOf0(string receivedItems)
        {
            //arrange
            CheckoutModel checkoutModel = new CheckoutModel()
            {
                CartContents = receivedItems,
                Subtotal = 30,
                DiscountApplied = 0,
                OffersAppliedText = "No Offers Applied.",
                CheckoutTotal = 30 - 0
            };

            //act
            var result = _cartController.Get(receivedItems);

            //assert
            result.Subtotal.Should().Be(checkoutModel.Subtotal);
            result.DiscountApplied.Should().Be(checkoutModel.DiscountApplied);
            result.OffersAppliedText.Should().Be(checkoutModel.OffersAppliedText);
            result.CheckoutTotal.Should().Be(checkoutModel.CheckoutTotal);
        }

        [TestCase("BB")]
        public void GivenBB_ShouldReturnSubTotalOf60DiscountOf15(string receivedItems)
        {
            //arrange
            CheckoutModel checkoutModel = new CheckoutModel()
            {
                CartContents = receivedItems,
                Subtotal = 60,
                DiscountApplied = 15,
                OffersAppliedText = "Item B Offer: Buy 2 for 45\n",
                CheckoutTotal = 60 - 15
            };

            //act
            var result = _cartController.Get(receivedItems);

            //assert
            result.Subtotal.Should().Be(checkoutModel.Subtotal);
            result.DiscountApplied.Should().Be(checkoutModel.DiscountApplied);
            result.OffersAppliedText.Should().Be(checkoutModel.OffersAppliedText);
            result.CheckoutTotal.Should().Be(checkoutModel.CheckoutTotal);
        }

        [TestCase("BBB")]
        public void GivenBBB_ShouldReturnSubTotalOf90DiscountOf15(string receivedItems)
        {
            //arrange
            CheckoutModel checkoutModel = new CheckoutModel()
            {
                CartContents = receivedItems,
                Subtotal = 90,
                DiscountApplied = 15,
                OffersAppliedText = "Item B Offer: Buy 2 for 45\n",
                CheckoutTotal = 90 - 15
            };

            //act
            var result = _cartController.Get(receivedItems);

            //assert
            result.Subtotal.Should().Be(checkoutModel.Subtotal);
            result.DiscountApplied.Should().Be(checkoutModel.DiscountApplied);
            result.OffersAppliedText.Should().Be(checkoutModel.OffersAppliedText);
            result.CheckoutTotal.Should().Be(checkoutModel.CheckoutTotal);
        }

        [TestCase("c")]
        public void GivenC_ShouldReturnSubTotalOf20DiscountOf0(string receivedItems)
        {
            //arrange
            CheckoutModel checkoutModel = new CheckoutModel()
            {
                CartContents = receivedItems,
                Subtotal = 20,
                DiscountApplied = 0,
                OffersAppliedText = "No Offers Applied.",
                CheckoutTotal = 20 - 0
            };

            //act
            var result = _cartController.Get(receivedItems);

            //assert
            result.Subtotal.Should().Be(checkoutModel.Subtotal);
            result.DiscountApplied.Should().Be(checkoutModel.DiscountApplied);
            result.OffersAppliedText.Should().Be(checkoutModel.OffersAppliedText);
            result.CheckoutTotal.Should().Be(checkoutModel.CheckoutTotal);
        }

        [TestCase("CCCCC")]
        public void GivenCCCCC_ShouldReturnSubTotalOf100DiscountOf0(string receivedItems)
        {
            //arrange
            CheckoutModel checkoutModel = new CheckoutModel()
            {
                CartContents = receivedItems,
                Subtotal = 100,
                DiscountApplied = 0,
                OffersAppliedText = "No Offers Applied.",
                CheckoutTotal = 100 - 0
            };

            //act
            var result = _cartController.Get(receivedItems);

            //assert
            result.Subtotal.Should().Be(checkoutModel.Subtotal);
            result.DiscountApplied.Should().Be(checkoutModel.DiscountApplied);
            result.OffersAppliedText.Should().Be(checkoutModel.OffersAppliedText);
            result.CheckoutTotal.Should().Be(checkoutModel.CheckoutTotal);
        }

        [TestCase("D")]
        public void GivenD_ShouldReturnSubTotalOf10DiscountOf0(string receivedItems)
        {
            //arrange
            CheckoutModel checkoutModel = new CheckoutModel()
            {
                CartContents = receivedItems,
                Subtotal = 15,
                DiscountApplied = 0,
                OffersAppliedText = "No Offers Applied.",
                CheckoutTotal = 15 - 0
            };

            //act
            var result = _cartController.Get(receivedItems);

            //assert
            result.Subtotal.Should().Be(checkoutModel.Subtotal);
            result.DiscountApplied.Should().Be(checkoutModel.DiscountApplied);
            result.OffersAppliedText.Should().Be(checkoutModel.OffersAppliedText);
            result.CheckoutTotal.Should().Be(checkoutModel.CheckoutTotal);
        }

        [TestCase("ab")]
        public void GivenAB_ShouldReturnSubTotalOf80DiscountOf0(string receivedItems)
        {
            //arrange
            CheckoutModel checkoutModel = new CheckoutModel()
            {
                CartContents = receivedItems,
                Subtotal = 80,
                DiscountApplied = 0,
                OffersAppliedText = "No Offers Applied.",
                CheckoutTotal = 80 - 0
            };

            //act
            var result = _cartController.Get(receivedItems);

            //assert
            result.Subtotal.Should().Be(checkoutModel.Subtotal);
            result.DiscountApplied.Should().Be(checkoutModel.DiscountApplied);
            result.OffersAppliedText.Should().Be(checkoutModel.OffersAppliedText);
            result.CheckoutTotal.Should().Be(checkoutModel.CheckoutTotal);
        }

        [TestCase("CDBA")]
        public void GivenCDBA_ShouldReturnSubTotalOf115DiscountOf0(string receivedItems)
        {
            //arrange
            CheckoutModel checkoutModel = new CheckoutModel()
            {
                CartContents = receivedItems,
                Subtotal = 115,
                DiscountApplied = 0,
                OffersAppliedText = "No Offers Applied.",
                CheckoutTotal = 115 - 0
            };

            //act
            var result = _cartController.Get(receivedItems);

            //assert
            result.Subtotal.Should().Be(checkoutModel.Subtotal);
            result.DiscountApplied.Should().Be(checkoutModel.DiscountApplied);
            result.OffersAppliedText.Should().Be(checkoutModel.OffersAppliedText);
            result.CheckoutTotal.Should().Be(checkoutModel.CheckoutTotal);
        }

        [TestCase("AAABB")]
        public void GivenAAABB_ShouldReturnSubTotalOf210DiscountOf35(string receivedItems)
        {
            //arrange
            CheckoutModel checkoutModel = new CheckoutModel()
            {
                CartContents = receivedItems,
                Subtotal = 210,
                DiscountApplied = 35,
                OffersAppliedText = "Item A Offer: Buy 3 for 130\nItem B Offer: Buy 2 for 45\n",
                CheckoutTotal = 210 - 35
            };

            //act
            var result = _cartController.Get(receivedItems);

            //assert
            result.Subtotal.Should().Be(checkoutModel.Subtotal);
            result.DiscountApplied.Should().Be(checkoutModel.DiscountApplied);
            result.OffersAppliedText.Should().Be(checkoutModel.OffersAppliedText);
            result.CheckoutTotal.Should().Be(checkoutModel.CheckoutTotal);
        }

        [TestCase("cdbbaaa")]
        public void GivenCDBBAAA_ShouldReturnSubTotalOf245DiscountOf35(string receivedItems)
        {
            //arrange
            CheckoutModel checkoutModel = new CheckoutModel()
            {
                CartContents = receivedItems,
                Subtotal = 245,
                DiscountApplied = 35,
                OffersAppliedText = "Item B Offer: Buy 2 for 45\nItem A Offer: Buy 3 for 130\n",
                CheckoutTotal = 245 - 35
            };

            //act
            var result = _cartController.Get(receivedItems);

            //assert
            result.Subtotal.Should().Be(checkoutModel.Subtotal);
            result.DiscountApplied.Should().Be(checkoutModel.DiscountApplied);
            result.OffersAppliedText.Should().Be(checkoutModel.OffersAppliedText);
            result.CheckoutTotal.Should().Be(checkoutModel.CheckoutTotal);
        }
    }
}