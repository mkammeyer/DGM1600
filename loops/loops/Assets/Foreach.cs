﻿using UnityEngine;
using System.Collections;

public class Foreach : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		string[] strings = new string[3];

		strings[0] = "First string";
		strings[1] = "Second string";
		strings[2] = "Third String";

		foreach(string item in strings)
		{
			print (item);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
