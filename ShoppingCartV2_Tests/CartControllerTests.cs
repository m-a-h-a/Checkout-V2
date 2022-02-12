using NUnit.Framework;
using ShoppingCartV2;
using ShoppingCartV2.Controllers;
using ShoppingCartV2.Models;
using FluentAssertions;

namespace ShoppingCartV2_Tests
{
    public class Tests
    {
        private CartController _cartController;

        [SetUp]
        public void Setup()
        {
            _cartController = new CartController();
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
        }

        [TestCase("a")]
        [TestCase("A")]
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
        [TestCase("aa")]
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
        [TestCase("AAA")]
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
        [TestCase("AAAA")]
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
        [TestCase("b")]
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
        [TestCase("bb")]
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
        [TestCase("bbb")]
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

        [TestCase("C")]
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
        [TestCase("ccccc")]
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
        [TestCase("d")]
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

        [TestCase("AB")]
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
        [TestCase("cdba")]
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
        [TestCase("aaabb")]
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
    }
}