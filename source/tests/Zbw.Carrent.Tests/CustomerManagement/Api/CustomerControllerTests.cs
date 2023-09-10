using FluentAssertions;

using Zbw.Carrent.CustomerManagement.Api;

namespace Zbw.Carrent.Tests.CustomerManagement.Api
{
    public class CustomerControllerTests
    {
        [Fact]
        public void Create_WhenNoRepository_ThenThrow()
        {
            Action act = () => new CustomerController(null!);

            act.Should().Throw<ArgumentNullException>();
        }
    }
}