using System.Diagnostics;
using System.IO;
using UnityEditor;

namespace Kogane.Internal
{
	internal static class ShowProjectInExplorer
	{
		[MenuItem( "File/Show Project in Explorer" )]
		private static void Show()
		{
			Process.Start( Directory.GetCurrentDirectory() );
		}
	}
}