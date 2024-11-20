using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorDemo
{
    public class Editor
    {
        public string content { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(content);
        }

        public void restore(EditorState state)
        {
            content = state.Content;
        }
    }
}
