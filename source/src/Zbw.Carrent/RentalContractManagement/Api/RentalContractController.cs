//namespace Zbw.Carrent.RentalContractManagement.Api
//{
//    [Route("api/rentalContract")]
//    [ApiController]
//    public class RentalContractController : ControllerBase
//    {
//        public RentalContractController(IRentalContractRepository repository)
//        {
//            ArgumentNullException.ThrowIfNull(repository);
//            _repository = repository;
//        }

//        [HttpGet]
//        public IEnumerable<RentalContractResponse> Get()
//        {
//            var rentalContracts = _repository.GetAll(r => r.Customer, r => r.Car);
//            return rentalContracts.Select(ConvertToRentalContractResponse);
//        }

//        [HttpGet("{id}")]
//        public RentalContractResponse Get(Guid id)
//        {
//            var customer = _repository.Get(id);
//            return ConvertToRentalContractResponse(customer);
//        }

//        [HttpPost]
//        public RentalContractResponse Post([FromBody] RentalContractRequest request)
//        {
//            var c = ConvertToRentalContract(request);
//            _repository.Add(c);
//            return ConvertToRentalContractResponse(c);
//        }

//        [HttpPut("{id}")]
//        public RentalContractResponse Put(Guid id, [FromBody] RentalContractRequest request)
//        {
//            var c = ConvertToRentalContract(request);
//            _repository.Update(c);
//            return ConvertToRentalContractResponse(c);
//        }

//        [HttpDelete("{id}")]
//        public void Delete(Guid id)
//        {
//            _repository.Remove(id);
//        }

//        private static RentalContract ConvertToRentalContract(RentalContractRequest request)
//        {
//            return new RentalContract(
//                Guid.NewGuid(),
//                request.DurationInDays,
//                request.Cost,
//                ConvertToCustomer(request.Customer),
//                ConvertToCar(request.Car)
//                );
//        }
//        private static RentalContractResponse ConvertToRentalContractResponse(RentalContract rentalContract)
//        {
//            return new RentalContractResponse(
//                rentalContract.Id,
//                rentalContract.DurationInDays,
//                rentalContract.Cost,
//                ConvertToCustomerResponse(rentalContract.Customer),
//                ConvertToCarResponse(rentalContract.Car)
//                );
//        }
//        private static Customer ConvertToCustomer(CustomerRequest customer)
//        {
//            return new Customer(customer.CustomerNr, customer.Name, customer.Street, customer.HouseNumber, customer.Postalcode, customer.City);
//        }
//        private static CustomerResponse ConvertToCustomerResponse(Customer customer)
//        {
//            return new CustomerResponse(customer.Id, customer.CustomerNr, customer.Name, customer.Street, customer.HouseNumber, customer.Postalcode, customer.City);
//        }
//        private static Car ConvertToCar(CarRequest car)
//        {
//            return new Car(
//                Guid.NewGuid(),
//                car.Name,
//                car.Brand,
//                car.Type,
//                car.Category,
//                car.DalyFee
//                );
//        }
//        private static CarResponse ConvertToCarResponse(Car car)
//        {
//            return new CarResponse(
//                car.Id,
//                car.Name,
//                car.Brand,
//                car.Type,
//                car.Category,
//                car.DalyFee
//                );
//        }

//        private readonly IRentalContractRepository _repository;
//    }
//}
