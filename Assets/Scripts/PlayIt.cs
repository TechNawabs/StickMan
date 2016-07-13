using UnityEngine;
using System.Collections;

public class PlayIt : MonoBehaviour 
{
	public GameObject gm,a,b;

	public void OnClick()
	{
		a.SetActive (false);
		b.SetActive (false);
		gm.SetActive (true);
	}

}