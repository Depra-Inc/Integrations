// SPDX-License-Identifier: Apache-2.0
// © 2023 Nikolay Melnikov <n.melnikov@depra.org>

using System;
using System.Collections.Generic;

namespace Depra.Integrations
{
	public sealed class IntegrationCollection : IIntegrationCollection, IDisposable
	{
		private readonly Dictionary<Type, IIntegration> _integrations = new();

		public void StartAll()
		{
			foreach (var integration in _integrations.Values)
			{
				integration.Start();
			}
		}

		public void Dispose()
		{
			foreach (var integration in _integrations.Values)
			{
				if (integration is IDisposable disposable)
				{
					disposable.Dispose();
				}
			}
		}

		IIntegration IIntegrationCollection.Resolve(Type type) =>
			_integrations.TryGetValue(type, out var integration) ? integration : new NullIntegration();

		void IIntegrationCollection.Register(Type type, IIntegration integration) =>
			_integrations.TryAdd(type, integration);
	}
}