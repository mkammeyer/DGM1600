using UnityEngine;
using System.Collections;

public class DuckSpawn : MonoBehaviour 
{
	public GameObject Duck;

	
	public void SpawnDuck()
	{
	// Instantiate here with Duck and transform.position and Quaterion.identiy
		Instantiate(Duck, transform.position, Quaternion.identity);
	
	}
}
