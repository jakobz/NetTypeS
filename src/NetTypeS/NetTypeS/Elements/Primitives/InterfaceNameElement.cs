﻿using NetTypeS.Interfaces;

namespace NetTypeS.Elements.Primitives
{
	/// <summary>
	/// TypeScript interface name element. Element formats interface name with name formatter.
	/// </summary>
	public class InterfaceNameElement : TypeNameElement
	{
		private readonly string interfaceName;

		/// <summary>
		/// Creates a new interface name element
		/// </summary>
		/// <param name="interfaceName">Interface name</param>
		public InterfaceNameElement(string interfaceName)
			: base(interfaceName)
		{
			this.interfaceName = interfaceName;
		}

		public override void Generate(IGeneratorModuleContext context)
		{
			context.Builder.Append(context.Formatter.FormatInterfaceName(interfaceName));
		}
	}
}