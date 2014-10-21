using System;
using MonoDevelop.Projects;
using MonoDevelop.Projects.Formats.MSBuild;

namespace MonoDevelop.ATSBinding {
    public class ATSResourceIdBuilder : MSBuildResourceHandler {
        public override string GetDefaultResourceId(ProjectFile pf) {
            return base.GetDefaultResourceId(pf);
        }
    }
}


