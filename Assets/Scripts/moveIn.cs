using UnityEngine;
using System.Collections;

public class moveIn : MonoBehaviour 
{
	public float sp;
	public Vector3 B;

	void Update()
	{
		transform.position = Vector3.MoveTowards (transform.position, B, Time.deltaTime * sp);
	}
}