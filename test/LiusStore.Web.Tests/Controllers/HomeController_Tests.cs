using System.Threading.Tasks;
using LiusStore.Models.TokenAuth;
using LiusStore.Web.Controllers;
using Shouldly;
using Xunit;

namespace LiusStore.Web.Tests.Controllers
{
    public class HomeController_Tests: LiusStoreWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}