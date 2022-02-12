# Checkout-V2
## Problem description
We’re going to see how far we can get in implementing a supermarket checkout API that calculates the total price of a number of items.  

In a normal supermarket, things are identified using Stock Keeping Units, or SKUs.  
In our store, we’ll use individual letters of the alphabet (A, B, C, D). Our goods are priced individually.

In addition, some items are multipriced: buy n of them, and they’ll cost you y pounds.  
For example, item ‘A’ might cost 50 pounds individually, but this week we have a special offer: buy three ‘A’s and they’ll cost you 130. The price and offer table:

Item	Price	Offer  
A	50	3 for 130  
B	30	2 for 45  
C	20	no offer  
D	15	no offer  

Our checkout accepts items in any order, so that if we scan a B, an A, and another B, we’ll recognize the two B’s and price them at 45 (for a total runnng price of 95).

The API must be exposed as a RESTful service, which can be called using Postman or similar.  
The API should accept a string, representing the contents of a shopping basket.  
The response should include the total price.  

## Example assertions
Here are a few unit test assertions to get you started:

Assert.That(0, Is.EqualTo(price_of("")))  
Assert.That(50, Is.EqualTo(price_of("A")))  
Assert.That(80, Is.EqualTo(price_of("AB")))  
Assert.That(115, Is.EqualTo(price_of("CDBA")))  
Assert.That(100, Is.EqualTo(price_of("AA")))  
Assert.That(130, Is.EqualTo(price_of("AAA")))  
Assert.That(175, Is.EqualTo(price_of("AAABB")))  
