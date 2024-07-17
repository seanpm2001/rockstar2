namespace Rockstar.Test.Parsing;

public abstract class ParserTestBase(ITestOutputHelper output) {
	private static readonly Parser parser = new();

	protected Program Parse(string source)
		=> parser.Parse(source);
}