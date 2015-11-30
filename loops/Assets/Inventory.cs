using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour 
{
	public class Stuff
	{
		public int bullets;
		
		public Stuff(int bul)
		{
			bullets = bul;
		}
		
		public Stuff()
		{
			bullets = 1;
		}
	}
public Stuff myStuff = new Stuff(50);	
	
	void Start () 
	{
		Debug.Log(myStuff.bullets);
	}
}
