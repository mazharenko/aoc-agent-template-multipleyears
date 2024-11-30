# Advent of Code Agent Template

Advent of Code Template based on [Advent of Code Agent](https://github.com/mazharenko/aoc-agent) project. It has all required references, contains drafts for all 25 days and a test project.

Compared to [aoc-agent-template](https://github.com/mazharenko/aoc-agent-template), this one assumes the repository will contain solutions for multiple years. The Agent library will know which year a day belongs to by its namespace &ndash; it must contain a segment like `YearXXXX`. Which year is run by the Agent is determined by the `[GenerateEntryPoint]` attribute on the correspondingly called class.