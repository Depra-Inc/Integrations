// SPDX-License-Identifier: Apache-2.0
// © 2023 Nikolay Melnikov <n.melnikov@depra.org>

using System;

namespace Depra.Integrations
{
	public sealed class IntegrationException : Exception
	{
		public IntegrationException(string message) : base(message) { }
	}
}