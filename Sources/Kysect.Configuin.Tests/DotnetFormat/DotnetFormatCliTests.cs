﻿using Kysect.Configuin.Core.DotnetFormat;
using NUnit.Framework;

namespace Kysect.Configuin.Tests.DotnetFormat;

public class DotnetFormatCliTests
{
    private readonly DotnetFormatCli _dotnetFormatCli;

    public DotnetFormatCliTests()
    {
        _dotnetFormatCli = new DotnetFormatCli();
    }

    [Test]
    [Ignore("This test require infrastructure")]
    public void Validate_FinishedWithoutErrors()
    {
        _dotnetFormatCli.Validate();
    }

    [Test]
    [Ignore("This test require infrastructure")]
    public void GenerateWarnings_CreateReportFile()
    {
        const string pathToSln = "./../../../../";

        _dotnetFormatCli.GenerateWarnings(pathToSln, "sample.json");
    }
}