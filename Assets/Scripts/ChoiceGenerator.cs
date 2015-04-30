using UnityEngine;
using System.Collections;

public class ChoiceGenerator
{
	public ChoiceGenerator(){
	}
	public string getChoice(char addition){
		string s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		string ch = "";
		var ar = new ArrayList();
		while (ch.Length < 3)
		{
			int i = Random.Range(0, s.Length - 1);
			if(ar.IndexOf(i)==-1 && !s[i].Equals(addition)){
				ar.Add(i);
				ch += s[i];
			}
		}
		ch += addition;
		return randomChoice(ch);
	}

	private string randomChoice(string x){
		string output = "";
		var ar = new ArrayList();
		while (output.Length < 4)
		{
			int i = Random.Range(0, 30) % 4;
			if(ar.IndexOf(i)==-1){
				ar.Add(i);
				output += x[i];
			}
		}
		return output;
	}
}

