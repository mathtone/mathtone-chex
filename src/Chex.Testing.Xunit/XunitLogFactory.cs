using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Chex.Testing.Xunit {
	public class XunitLogFactory : IAppLoggerFactory {

		readonly ITestOutputHelper _output;

		public XunitLogFactory(ITestOutputHelper output) =>
			_output = output;

		public ILogger<T> CreateLogger<T>() => new XunitLogger<T>(_output);
	}
}