﻿using System.Collections.Immutable;
using System.Text;

namespace Kysect.Configuin.EditorConfig.DocumentModel.Nodes;

public record EditorConfigCategoryNode(string Value, ImmutableList<IEditorConfigNode> Children, ImmutableList<string> LeadingTrivia, string? TrailingTrivia) : IEditorConfigContainerNode
{
    public EditorConfigCategoryNode(string value) : this(value, ImmutableList<IEditorConfigNode>.Empty, ImmutableList<string>.Empty, null)
    {
    }

    IEditorConfigContainerNode IEditorConfigContainerNode.AddChild(IEditorConfigNode child)
    {
        return AddChild(child);
    }

    public EditorConfigCategoryNode AddChild(IEditorConfigNode child)
    {
        return this with { Children = Children.Add(child) };
    }

    public string ToFullString()
    {
        var stringBuilder = new StringBuilder();
        LeadingTrivia.ForEach(s => stringBuilder.AppendLine(s));

        string line = $"[{Value}]";
        if (TrailingTrivia is not null)
            line += $"{line} {TrailingTrivia}";
        stringBuilder.Append(line);

        Children.ForEach(c => stringBuilder.Append($"{Environment.NewLine}{c.ToFullString()}"));
        return stringBuilder.ToString();
    }
}