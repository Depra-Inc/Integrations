// SPDX-License-Identifier: Apache-2.0
// © 2023 Nikolay Melnikov <n.melnikov@depra.org>

namespace Depra.Integrations
{
	public readonly struct NullIntegration : IIntegration
	{
		void IIntegration.Start() => throw new IntegrationException("Integration is null!");
	}
}