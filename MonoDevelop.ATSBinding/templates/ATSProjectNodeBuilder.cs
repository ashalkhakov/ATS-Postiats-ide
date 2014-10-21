using System;
using System.Linq;

using MonoDevelop.Ide.Gui.Components;

namespace MonoDevelop.ATSBinding
{
    class ATSProjectNodeBuilder: NodeBuilderExtension
    {
        public override bool CanBuildNode (Type dataType)
        {
            return typeof(ATSProject).IsAssignableFrom (dataType);
        }

        public override Type CommandHandlerType {
            get { return typeof(ATSProjectCommandHandler); }
        }

        public override bool HasChildNodes (ITreeBuilder builder, object dataObject)
        {
            return true;
        }
        public override void BuildChildNodes (ITreeBuilder treeBuilder, object dataObject)
        {
            var project = (ATSProject)dataObject;
            //treeBuilder.AddChild (project.AddinReferences);
        }
        public override void OnNodeAdded (object dataObject)
        {
            var project = (ATSProject)dataObject;
            //project.AddinReferenceAdded += OnReferencesChanged;
            //project.AddinReferenceRemoved += OnReferencesChanged;
            base.OnNodeAdded (dataObject);
        }
        public override void OnNodeRemoved (object dataObject)
        {
            var project = (ATSProject)dataObject;
            //project.AddinReferenceAdded -= OnReferencesChanged;
            //project.AddinReferenceRemoved -= OnReferencesChanged;
            base.OnNodeRemoved (dataObject);
        }
        class ATSProjectCommandHandler : NodeCommandHandler
        {
        }
    }
}