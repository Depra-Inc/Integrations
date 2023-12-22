// SPDX-License-Identifier: Apache-2.0
// © 2023 Nikolay Melnikov <n.melnikov@depra.org>

using System;

namespace Depra.Integrations
{
	public interface IIntegrationCollection
	{
		IIntegration Resolve(Type type);

		void Register(Type type, IIntegration integration);
	}
}