using UnityEngine;
using System.Collections;

public class DirectionChanger : MonoBehaviour 
{
	public enum DirChanger{Horizontal,Vertical};
	public DirChanger changer;
	
	private DuckMovement duckMovement;
	
	void OnCollisionEnter(Collision hit)
	{
		if(hit.transform.tag == "Duck")
		{
			//create duckmovement varible. Assign using getComponent of hit
			duckMovement = GetComponent<DuckMovement>();
			
			if(changer == DirChanger.Horizontal)
			{
				// duckmovement varible and call the directionchanger function. new vector3(-1,1,0)
				duckMovement.DirectionChanger(new Vector3(-1,1,0));
			}
			if(changer == DirChanger.Vertical)
			{
				// duckmovement varible and call the directionchanger function. new vector3(1,-1,0)
				duckMovement.DirectionChanger(new Vector3(1,-1,0));
			}
		}
	}


}
