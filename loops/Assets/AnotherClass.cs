﻿using UnityEngine;
using System.Collections;

public class AnotherClass : MonoBehaviour 
{
	public int apples;
	public int bananas;
	
	private int stapler;
	private int sellotape;

	public void FruitMachine (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("Fruit Total:" + answer);
	}
	private void OfficeSort (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("Office Supplies Total:" + answer);
	}
}
