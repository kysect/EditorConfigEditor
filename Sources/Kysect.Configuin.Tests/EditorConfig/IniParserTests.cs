﻿using Kysect.Configuin.EditorConfig.IniParsing;

namespace Kysect.Configuin.Tests.EditorConfig;

public class IniParserTests
{
    private readonly IniParser _parser = new IniParser();

    [Fact]
    public void Parse_SimpleLine_ReturnParsedKeyValue()
    {
        string content = "key = value";

        IReadOnlyCollection<IniFileLine> result = _parser.Parse(content);

        result
            .Should().HaveCount(1)
            .And.Contain(new IniFileLine("key", "value"));
    }

    [Fact]
    public void Parse_LineWithComment_ReturnParsedKeyValue()
    {
        string content = "# key = value";

        IReadOnlyCollection<IniFileLine> result = _parser.Parse(content);

        result.Should().HaveCount(0);
    }

    [Fact]
    public void Parse_EditorConfigFile_ParsedWithoutErrors()
    {
        string fileText = File.ReadAllText(Path.Combine("Resources", "Editor-config-sample.ini"));

        IReadOnlyCollection<IniFileLine> result = _parser.Parse(fileText);

        // TODO: add more asserts
        result.Should().HaveCount(393);
    }
}