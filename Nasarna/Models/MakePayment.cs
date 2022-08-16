using System.Threading.Tasks;
using Stripe;
namespace WebApplication1.Models
{
    public class MakePayment
    {
        public static async Task<dynamic> PayAsync(string cardNumber, int month, int year, string cvc, int value)
        {
            try
            {
                StripeConfiguration.ApiKey = "sk_test_51LWGsTLidAx3LRO5OE3p3YSO5iOgaD3q0EVLdP74IR4rBpfvK5gxxSxnHwmfeK2LGMxyMC1Bce0S4Y76z9SUN1X200VPCSoNcf";

                var optionsToken = new TokenCreateOptions
                {
                    Card = new CreditCardOptions
                    {
                        Number = cardNumber,
                        ExpMonth = month,
                        ExpYear = year,
                        Cvc = cvc
                    }
                };

                var serviceToken = new TokenService();
                Token stripeToken = await serviceToken.CreateAsync(optionsToken);

                var options = new ChargeCreateOptions
                {
                    Amount = value * 100,
                    Currency = "usd",
                    Description = "test",
                    Source = stripeToken.Id
                };

                var service = new ChargeService();
                Charge charge = await service.CreateAsync(options);

                if (charge.Paid)
                {
                    return "Success";
                }
                else
                {
                    return "Failed";
                }
            }
            catch (System.Exception e)
            {

                return e.Message;
            }
        }
    }
}
