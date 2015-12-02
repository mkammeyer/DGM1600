using UnityEngine;
using System.Collections;

public class EnumScript : MonoBehaviour 
{
	enum Direction{North, East, South, West};
	
	void Start ()
	{
		Direction myDirection;
		
		myDirection = Direction.North;
		
	}		
	
	Direction ReverseDirection (Direction dir)
	{
		if(dir == Direction.North)
			dir = Direction.South;
		return dir;
	}
}
