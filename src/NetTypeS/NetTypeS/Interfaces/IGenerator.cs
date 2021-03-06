﻿using System.Collections.Generic;

namespace NetTypeS.Interfaces
{
	/// <summary>
	/// TypeScript code generator interface
	/// </summary>
	public interface IGenerator
	{
		/// <summary>
		/// Creates a new module it it is not exist.
		/// </summary>
		/// <param name="moduleName">Module name.</param>
		/// <param name="decalration">If module should be declared.</param>
		/// <param name="export">If module should be exported.</param>
		/// <returns>Found or created module.</returns>
		IGeneratorModule GetModule(string moduleName, bool decalration = false, bool export = false);

		/// <summary>
		/// Generates TypeScript with pointed exportedModules or with all if them are not pointed
		/// </summary>
		/// <param name="exportedModules">Modules for generation.</param>
		/// <returns>Generated string.</returns>
		string Generate(params string[] exportedModules);

		/// <summary>
		/// Contains information about custom names registered in the generator.
		/// </summary>
		ICustomTypeNameHolder CustomTypeNameHolder { get; }

		/// <summary>
		/// Type collector. Collects information about types added for generation.
		/// </summary>
		ITypeCollector TypeCollector { get; }

		/// <summary>
		/// Inherited type lookup interface.
		/// </summary>
		IInheritedTypeSpy InheritedTypeSpy { get; }

		/// <summary>
		/// Generator settings.
		/// </summary>
		IGeneratorSettings Settings { get; }

		/// <summary>
		/// TypeScript file references.
		/// </summary>
		ICollection<string> References { get; }
	}
}