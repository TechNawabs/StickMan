using UnityEngine;
using System.Collections;

public class StarRotator : MonoBehaviour 
{
	public float speed;

	void Update()
	{
		transform.Rotate (0, 0, speed * Time.deltaTime);
	}
		
}