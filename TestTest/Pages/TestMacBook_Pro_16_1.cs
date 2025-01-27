using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Test.Pages;

namespace TestTest
{
  [Collection("Test")]
  public class TestMacBook_Pro_16_1
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbIconButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbInputModule),
        typeof(IgbButtonModule));
      var componentUnderTest = ctx.RenderComponent<MacBook_Pro_16_1>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
