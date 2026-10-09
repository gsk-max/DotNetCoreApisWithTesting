using Microsoft.AspNetCore.Mvc.Testing;
namespace ApiUnitTesting
{
    public class UnitTest1
    {
        WebApplicationFactory<Program> factory;
        HttpClient client;

        public UnitTest1()
        {
            factory = new WebApplicationFactory<Program>();
            client = factory.CreateClient();

        }


        [Fact]
        public async Task FirstApiTest()
        {
            var response = await client.GetAsync("api/firstd");
            int statusCode = (int)response.StatusCode;
            Assert.Equal(200, statusCode);
        }


        [Theory]
        [InlineData(5,25)]
        [InlineData(2,5)]
        [InlineData(7,49)]
        [InlineData(15,2255)]
        public async Task SquareApiTest(int n, int expected)
        {
            var response = await client.PostAsync("api/square/" + n,null);
            int result = Convert.ToInt32(await response.Content.ReadAsStringAsync());
            Assert.Equal(expected,result);
             
        }
    }
}
