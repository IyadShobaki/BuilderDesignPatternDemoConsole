﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.FluentBuilder
{
    public class HtmlElement
    {
        private const int _indentSize = 2;
        public string Name { get; set; }
        public string Text { get; set; }
        public List<HtmlElement> Elements { get; private set; } = new List<HtmlElement>();
        public HtmlElement()
        {

        }

        public HtmlElement(string name, string text)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }
        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', _indentSize * indent);
            sb.AppendLine($"{i}<{Name}>");
            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', _indentSize * (indent + 1)));
                sb.AppendLine(Text);
            }
            foreach (var e in Elements)
            {
                sb.Append(e.ToStringImpl(indent + 1));
            }
            sb.AppendLine($"</{Name}>");
            return sb.ToString();
        }
        public override string ToString()
        {
            return ToStringImpl(0);
        }
    }
}
