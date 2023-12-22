// SPDX-License-Identifier: Apache-2.0
// © 2023 Nikolay Melnikov <n.melnikov@depra.org>

namespace Depra.Integrations
{
	public static class IntegrationCollectionExtensions
	{
		public static IIntegration Resolve<TIntegration>(this IIntegrationCollection self) =>
			self.Resolve(typeof(TIntegration));

		public static void Register<TIntegration>(this IIntegrationCollection self, IIntegration integration) =>
			self.Register(typeof(TIntegration), integration);
	}
}