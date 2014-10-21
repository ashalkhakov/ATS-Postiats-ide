using System;
using System.IO;
using MonoDevelop.Core;
using MonoDevelop.Ide;
using MonoDevelop.Projects;

namespace MonoDevelop.ATSBinding {
    public class ATSProjectServiceExtension : ProjectServiceExtension {
        public override bool SupportsItem(IBuildTarget item)
        {
            // Extend any ATS project
            return (item is DotNetProject) && (item as DotNetProject).LanguageName == "ATS";
        }
    }
}
