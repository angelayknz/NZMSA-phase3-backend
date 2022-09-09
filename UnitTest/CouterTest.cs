using Xunit;
using Bunit;
using BlazorEcommerce.Client.Pages;
using BlazorEcommerce.Client.Shared;

namespace BlazorAppTests
{
    public class CounterTest
    {
        [Fact]
        public void RendersSuccessfully()
        {

            using var ctx = new TestContext();

            // Render Counter component.
            var component = ctx.RenderComponent<Counter>();

            // Assert: first, find the parent_name vital element, then verify its content.
            Assert.Equal("Click me", component.Find($".btn").TextContent);
        }

    }
}
