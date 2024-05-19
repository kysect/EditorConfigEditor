﻿using System.Collections.Immutable;
using System.Text;

namespace Kysect.Configuin.EditorConfig.DocumentModel.Nodes;

public record EditorConfigRuleOptionNode(
    string Key,
    EqualSymbol EqualSymbol,
    string Value,
    ImmutableList<string> LeadingTrivia,
    string? TrailingTrivia
) : IEditorConfigPropertyNode
{
    public EditorConfigRuleOptionNode(string key, EqualSymbol equalSymbol, string value) : this(key, equalSymbol, value, [], null)
    {
    }

    public EditorConfigRuleOptionNode(string key, string value) : this(key, EqualSymbol.Empty, value, [], null)
    {
    }

    public IEditorConfigPropertyNode WithLeadingTrivia(ImmutableList<string> leadingTrivia)
    {
        return this with { LeadingTrivia = leadingTrivia };
    }

    public IEditorConfigPropertyNode WithTrailingTrivia(string? trailingTrivia)
    {
        return this with { TrailingTrivia = trailingTrivia };
    }

    public string ToFullString()
    {
        // TODO: reduce duplication
        var fullString = $"{Key}{EqualSymbol.ToFullString()}{Value}";
        var stringBuilder = new StringBuilder();
        LeadingTrivia.ForEach(s => stringBuilder.AppendLine(s));

        if (TrailingTrivia is not null)
            fullString += $"#{TrailingTrivia}";

        stringBuilder.Append(fullString);
        return stringBuilder.ToString();
    }
}