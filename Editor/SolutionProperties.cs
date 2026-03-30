/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Collections.Generic;

namespace Antigravity.IDE.Editor
{
	internal class SolutionProperties
	{
		public string Name { get; set; }
		public IList<KeyValuePair<string, string>> Entries { get; set; }
		public string Type { get; set; }
	}
}
