using UnityEngine;
using System.Collections;

public class IF : MonoBehaviour 
{
	float coffeeTemperature = 85.0f;
	float hotLimitTemperature = 70.0f;
	float coldLimitTemperature = 40.0f;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();
		
		coffeeTemperature -= Time.deltaTime * 5f;
	}

	void TemperatureTest()
	{
		if (coffeeTemperature > hotLimitTemperature) 
		{
			print ("Coffee is too Hot");
		}
		else if (coffeeTemperature < coldLimitTemperature)
		{
			print ("Coffee is too Cold");
		}
		else
		{
			print ("Just right");
		}
	}

}
