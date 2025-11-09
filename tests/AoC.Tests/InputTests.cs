using mazharenko.AoCAgent.Generator;

namespace AoC.Tests;

[TestFixture]
[GenerateInputTests(2025, nameof(GetCases))]
internal partial class InputTests
{
    private static IEnumerable<PartInputCaseData> GetCases()
    {
        yield break;
    }
}