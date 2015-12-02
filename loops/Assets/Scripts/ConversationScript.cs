using UnityEngine;
using System.Collections;

public class ConversationScript : MonoBehaviour 
{
	public int intellegence = 5;
	
	void Greet()
	{
		switch(intellegence)
		{
			case 5:
				print("Hello Good sir, how are you");
				break;
			case 4:
				print ("Good morning!");
				break;
			default:
				print ("incorrect intellegence level");
				break;
		}
	}
}
