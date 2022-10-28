// Generate C# L-system fractals

string axiom = "ABA";

string ruleA = "ABA";
string ruleB = "BAB";

string outputFractal = "";

string buildFractal(string axiom, string A, string B) {

	List<string> fractalParts = new List<string>();

	foreach(char i in axiom) {

		if(i == 'A') fractalParts.Add(A);
		else if(i == 'B') fractalParts.Add(B);		
	}

	outputFractal = string.Join("", fractalParts.ToArray());
	return outputFractal;
}

outputFractal = buildFractal(axiom, ruleA, ruleB);
Console.WriteLine(outputFractal);