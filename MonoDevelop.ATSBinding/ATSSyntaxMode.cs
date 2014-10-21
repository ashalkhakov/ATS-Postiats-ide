using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

using Mono.TextEditor;
using Mono.TextEditor.Highlighting;

namespace MonoDevelop.ATSBinding
{
    public class ATSSyntaxMode : SyntaxMode, IDisposable
    {
        static SyntaxMode _baseMode;

        public ATSSyntaxMode()
        {
            var matches = new List<Match>();

            if (_baseMode == null)
            {
                var provider = new ResourceStreamProvider(
                    typeof(ATSSyntaxMode).Assembly,
                    typeof(ATSSyntaxMode).Assembly.GetManifestResourceNames().First(s => s.Contains("ATSSyntaxMode")));
                using (Stream s = provider.Open())
                    _baseMode = SyntaxMode.Read(s);
            }

            this.rules = new List<Rule>(_baseMode.Rules);
            this.keywords = new List<Keywords>(_baseMode.Keywords);
            this.spans = new List<Span>(_baseMode.Spans).ToArray();
            matches.AddRange(_baseMode.Matches);
            this.prevMarker = _baseMode.PrevMarker;
            this.SemanticRules = new List<SemanticRule>(_baseMode.SemanticRules);
            this.keywordTable = _baseMode.keywordTable;
            this.keywordTableIgnoreCase = _baseMode.keywordTableIgnoreCase;
            this.properties = _baseMode.Properties;
            this.matches = matches.ToArray();
        }

        public virtual void Dispose() {
            // nothing as of yet
        }
    }
}

