using UnityEngine;
using System.Collections;

public class Introstart : MonoBehaviour 
{
	public GameObject book;

	public void OnMouseEnter()
	{
		gameObject.GetComponent<Renderer> ().material.color = Color.green;
	}

	public void OnMouseUp()
	{
		book.GetComponent<Animator> ().enabled = true;
		gameObject.SetActive (false);
	}

	public void OnMouseExit()
	{
		gameObject.GetComponent<Renderer> ().material.color = Color.white;
	}

}