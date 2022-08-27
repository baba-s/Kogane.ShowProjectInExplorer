using System.Diagnostics;
using System.IO;
using UnityEditor;

namespace Kogane.Internal
{
    internal static class ShowProjectInExplorer
    {
#if UNITY_EDITOR_WIN
        [MenuItem( "File/Show Project in Explorer" )]
#else
        [MenuItem( "File/Show Project in Finder" )]
#endif
        private static void Show()
        {
            Process.Start( Directory.GetCurrentDirectory() );
        }
    }
}