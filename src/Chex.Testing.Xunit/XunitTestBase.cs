using Microsoft.Extensions.Logging;
using Xunit;
using Xunit.Abstractions;

namespace Chex.Testing.Xunit {
	public abstract class XunitTestBase<F> : XunitTestBase, IClassFixture<F> where F : class {

		public F TestData { get; }

		public XunitTestBase(ITestOutputHelper output, F fixture) : base(output) {
			TestData = fixture;
		}
	}

	public abstract class XunitTestBase : IAppLoggerFactory {

		protected ITestOutputHelper Output { get; }

		public XunitTestBase(ITestOutputHelper output) =>
			Output = output;

		public ILogger<T> CreateLogger<T>() => new XunitLogger<T>(Output);
	}


}