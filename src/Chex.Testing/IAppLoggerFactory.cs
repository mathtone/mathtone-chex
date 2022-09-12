using Microsoft.Extensions.Logging;

namespace Chex.Testing {
	public interface IAppLoggerFactory {
		ILogger<T> CreateLogger<T>();
	}
}
