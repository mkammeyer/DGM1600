using UnityEngine;
using System.Collections;

public class ForEachLoop : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		string [] strings = new string[3];
		
		string[0] = "First string";
		string[1] = "Second string";
		string[2] = "Third string";
		
		foreach(string item in strings)
		{
			print(item);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
