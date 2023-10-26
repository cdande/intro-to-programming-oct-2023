using Alba;
namespace DemoApi.ContractTests.Todos;
public class GettingTodos
{

	[Fact]
	public async Task CanGetATodo()
	{
		var host = await AlbaHost.For<Program>();

		await host.Scenario(api =>
		{
			api.Get.Url("/todo-list/808205e0-de44-493f-afa1-9bb8cfdbf3d1");
			api.StatusCodeShouldBeOk();
		});


		await host.Scenario(api =>
		{
			api.Get.Url("/todo-list/" + Guid.NewGuid().ToString());
			api.StatusCodeShouldBe(404);
		});
	}
}
