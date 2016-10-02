using UnityEngine;
using System.Collections;

public class movCamera : MonoBehaviour 
{
	public Camera cam;
	public Transform target;

	public StartGame sg;

	void Update()
	{
		//To run game on multiple screen sizes without affecting pixels use
		//cam.orthographicSize = (Screen.height / 100f) / 4f;

		if (sg.playClicked) 
		{
			transform.position = Vector3.Lerp (transform.position, target.position, 0.2f);
		}
	}
		
}