﻿// Copyright (c) Microsoft Corporation and Contributors
// Licensed under the MIT license.

using System;
using System.Diagnostics.Tracing;
using DevHome.Telemetry;
using Microsoft.Diagnostics.Telemetry;
using Microsoft.Diagnostics.Telemetry.Internal;

namespace DevHome.Common.TelemetryEvents.DeveloperId;

[EventData]
public class EntryPointEvent : EventBase
{
    public override PartA_PrivTags PartA_PrivTags => PrivTags.ProductAndServiceUsage;

    public string EntryPointName
    {
        get;
    }

    public enum EntryPoint
    {
        None = 0,
        Settings = 1,
        SetupFlow = 2,
        WhatsNewPage = 3,
        Widget = 4,
    }

    private readonly string[] entryPointNames =
    {
        string.Empty,
        "Settings",
        "SetupFlow",
        "WhatsNewPage",
        "Widget",
    };

    public EntryPointEvent(EntryPoint entryPoint)
    {
        EntryPointName = entryPointNames[(int)entryPoint];
    }

    public override void ReplaceSensitiveStrings(Func<string, string> replaceSensitiveStrings)
    {
        // There are no sensitive strings
    }
}
