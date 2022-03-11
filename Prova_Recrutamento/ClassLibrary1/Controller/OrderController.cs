namespace UnityOfShop.Controllers
{

    [ApiController]
    [Route("v1/orders")]
    public class OrderController : BaseController 
    {

        [HttpPost]
        [Route("")]
        public Order post([FromServices]ICustomerRepository customerRepository,
                          [FromServices]IOrderRepository orderRepository,
                          [FromServices]IUnityOfWork uow)
        {
        try 
        {    var customer = new customer{Name="User1"};
            var Order = new Order {Number="123", Customer=customer};

            customerRepository.Save(customer);
            orderRepository.Save(Order);

            uow.Commit();


            return Order;
            }catch
            {
                uow.Rollback();
                return null;
            }


        }
    }
        
}