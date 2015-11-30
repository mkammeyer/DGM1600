using UnityEngine;
using System.Collections;

public class DoWhileLoop : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		bool shouldContinue = false;
		
		do
		{
			print ("Hello World!");
		}
		while(shouldContinue == true); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
