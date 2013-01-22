// Class1.cs
//

using System;
using System.Collections.Generic;
using System.Html;
using jQueryApi;
using System.Runtime.CompilerServices;

namespace ScriptLibrary1
{

    [ScriptNamespace("Scripts")]
    public class TextPreviewer
    {
        private TextElement _text;
        private DivElement _div;
        public TextPreviewer(string textElementId, string divElementId)
        {
            _text = Document.GetElementById(textElementId).As<TextElement>();
            _div = Document.GetElementById(divElementId).As<DivElement>();
        }
        public void Initialize()
        {
            if (!Script.IsNullOrUndefined(_text))
                _text.AddEventListener("keyup", OnKeyUpListener, false);
        }
        private void OnKeyUpListener(ElementEvent e)
        {
            if (!Script.IsNullOrUndefined(_div))
                _div.InnerHTML = _text.Value;
        }

        public string TestValue()
        {
            return "Test Hello World Value String!!!";
        }

        public Element ElementById(string id)
        {
            return Document.GetElementById(id);
        }

        public List<Person> People()
        {
            List<Person> l = new List<Person>();
            Person a = new Person("Asger");
            l.Add(a);
            return  l;
        }

        
    }

    public class Person
    {
        public string Name
        {
            get
            {
                return _Name;
            }
        }
        private string _Name;

        public Person(string name)
        {
            _Name = name;
        }
    }
}
