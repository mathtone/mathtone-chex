using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Chex.Testing.Xunit {

	public class XunitLogger<T> : ILogger<T>, IDisposable {

		private readonly ITestOutputHelper _output;

		public XunitLogger(ITestOutputHelper output) =>
			_output = output;

		public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter) {
			try {
				_output.WriteLine(state?.ToString());
			}
			catch (InvalidOperationException) { }
		}

		public bool IsEnabled(LogLevel logLevel) => true;

		public IDisposable BeginScope<TState>(TState state) => this;

		public void Dispose() {
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing) {
			if (disposing) {
				;
			}
		}
	}

	public static class ServiceCollectionExtensions {
		public static IServiceCollection AddXunitLogging(this IServiceCollection services, ITestOutputHelper output) =>
			services.AddSingleton(output)
				.AddSingleton(typeof(ILogger<>), typeof(XunitLogger<>));
	}
}