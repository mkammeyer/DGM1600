using UnityEngine;
using System.Collections;

public class DuckMovement : MonoBehaviour 
{
	public float speed;
	public Vector3 direction;
	
	void Start()
	{
		RandomDirection();
	}
	
	void Update () 
	{
		//move the duck by changing the position of the transform. Times.direction with speed
		transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
	
	}
	
	public void RandomDirection ()
	{
		direction = new Vector3(Random.Range(-1f, 1f), Random.Range(.2f, 1f), 0);
	}
	
	public void DirectionChanger(Vector3 _dir)
	{
		direction = new Vector3(direction.x * _dir.x, direction.y * _dir.y, 0);
	}
}
