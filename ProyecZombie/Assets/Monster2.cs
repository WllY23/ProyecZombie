using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster2 : MonoBehaviour
{
	public float spacing;
	public int id;
	void Start () 
	{
		Debug.Log ("Im alive!");
	}

	void Update ()
	{
		float wave = Mathf.Sin (Time.fixedTime + id);
		transform.position = new Vector3 (id * spacing, wave, 0);
	}

}
