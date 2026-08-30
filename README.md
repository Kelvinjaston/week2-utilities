# Week 2 Utilities

A small, tested C# utility library built as part of Week 2 of the internship program.

## Overview

This solution contains a `NormalizeAmount` helper used to normalize monetary values:
it removes any negative sign and rounds the amount to 2 decimal places using
standard "round half away from zero" behavior (rather than .NET's default
banker's rounding), which matches how monetary values are typically expected
to round.

## Project Structure

```
Week2-Utilities/
├── Utilities/                          # Class library
│   ├── NormalizeAmountHelper.cs
│   └── Utilities.csproj
├── Utilities.Tests/                     # xUnit test project
│   ├── NormalizeAmountHelperTests.cs
│   └── Utilities.Tests.csproj
└── Utilities.slnx                       # Solution file
```

## The NormalizeAmount Helper

```csharp
public static class NormalizeAmountHelper
{
    public static decimal Normalize(decimal amount)
    {
        return Math.Abs(Math.Round(amount, 2, MidpointRounding.AwayFromZero));
    }
}
```

| Input      | Output   |
|------------|----------|
| -45.678    | 45.68    |
| 100.005    | 100.01   |
| 0          | 0.00     |

## Running the Tests

From the solution root:

```bash
dotnet test
```

Expected output:

```
Test summary: total: 6, failed: 0, succeeded: 6, skipped: 0
```

## Tech Stack

- .NET 10 / C# 14
- xUnit for testing

## Notes

- Math.Round defaults to banker's rounding (round-half-to-even) in .NET.
  This library explicitly uses MidpointRounding.AwayFromZero so that values
  like 100.005 round up to 100.01 as expected for standard financial rounding,
  rather than down to 100.00.
