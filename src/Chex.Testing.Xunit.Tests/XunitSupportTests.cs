using Xunit.Abstractions;

namespace Chex.Testing.Xunit.Tests {

	public class SupportTestFixture { }

	public class XunitSupportTests : XunitTestBase<SupportTestFixture> {

		public XunitSupportTests(ITestOutputHelper output, SupportTestFixture fixture) :
			base(output, fixture) {
		}

		[Fact]
		public void CanConstructTestFixture() { }
	}
}