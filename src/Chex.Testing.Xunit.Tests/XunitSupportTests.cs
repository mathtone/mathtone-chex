using Xunit.Abstractions;

namespace Chex.Testing.Xunit.Tests {

	public class SupportTestFixture { }

	public class XunitSupportTests : XunitTestBase<SupportTestFixture> {

		public XunitSupportTests(SupportTestFixture fixture, ITestOutputHelper output) : base( output,fixture) {
		}

		[Fact]
		public void CanConstructTestFixture() => Assert.NotNull(this.TestData);
	}
}