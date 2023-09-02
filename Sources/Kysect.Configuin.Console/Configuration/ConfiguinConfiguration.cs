﻿using System.ComponentModel.DataAnnotations;

namespace Kysect.Configuin.Console.Configuration;

public class ConfiguinConfiguration
{
    [Required]
    public string MsLearnRepositoryPath { get; init; } = null!;

    [Required]
    public string EditorConfigFile { get; init; } = null!;

    [Required]
    public string OutputPath { get; init; } = null!;
}