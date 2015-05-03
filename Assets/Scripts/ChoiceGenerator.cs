using UnityEngine;
using System.Collections;

public class ChoiceGenerator
{
	public ChoiceGenerator(){
	}
	public string GetChoice(char addition){
		string s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		string ch = "";
		var ar = new ArrayList();
		while (ch.Length < 3)
		{
			int i = Random.Range(0, s.Length);
			if(ar.IndexOf(i)==-1 && !s[i].Equals(addition)){
				ar.Add(i);
				ch += s[i];
			}
		}
		ch += addition;
		return RandomChoice(ch);
	}

	private string RandomChoice(string args){
		string output = "";
		var ar = new ArrayList();
		while (output.Length < 4)
		{
			int i = Random.Range(0, 30) % 4;
			if(ar.IndexOf(i)==-1){
				ar.Add(i);
				output += args[i];
			}
		}
		return output;
	}
}

