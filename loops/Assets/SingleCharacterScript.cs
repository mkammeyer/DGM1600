using UnityEngine;
using System.Collections;

public class SingleCharacterScript : MonoBehaviour 
{
	public class Stuff
	{
		public int bullets;
		public int grenades;
		public int rockets;
		
		public Stuff(int bul, int gre, int roc)
		{
			bullets = bul;
			grenades = gre;
			rockets = roc;
		}
	}
	
	public Stuff myStuff = new Stuff(10, 7, 25);
	public float speed;
	public float turnSpeed;
	public Rigidbody bulletPrefab;
	public Transform firePosition;
	public float bulletSpeed;
	
	
	// Update is called once per frame
	void Update () 
	{
		Movement();
		Shooting();
	}
	void Movement()
	{
		float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
		float turnMovement = Input.GetAxis("Horizontal") *  turnSpeed * Time.deltaTime;
		
		transform.Translate(Vector3.forward * forwardMovement);
		transform.Translate(Vector3.up * turnSpeed);	
	}
	
	void Shooting()
	{
		if(Input.GetButtonDown("Fire1") && myStuff.bullets > 0)
		{
			Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
			bulletInstance.AddForce(firePosition.forward * bulletSpeed);
			myStuff.bullets--;
		}
	}
}
