using UnityEngine;
using System.Collections;

public class ForLoop2 : MonoBehaviour 
{

	int numEnemies = 3;
	
	// Use this for initialization
	void Start () 
	{
		for(int i = 0; i < numEnemies; i++)
		{
			Debug.Log("Number of enemies" + i);
		}
	}
	
}
