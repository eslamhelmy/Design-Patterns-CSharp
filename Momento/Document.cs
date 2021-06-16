using System;
using System.Collections.Generic;
using System.Text;

namespace Momento
{
    public class Document
    {
        public string Content { set; get; }
        public string FontSize { set; get; }
        public string FontName { set; get; }

 
        public Document restore(DocumentState state)
        {
            return new Document
            {
                Content = state.Content,
                FontName = state.FontName,
                FontSize = state.FontSize
            };
        }

        public DocumentState CreateState()
        {
            return new DocumentState
            {
                Content = Content,
                FontName = FontName,
                FontSize = FontSize
            };
        }
    }
}
