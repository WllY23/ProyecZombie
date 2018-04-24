using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour 
{
	public PrimitiveType primitiveType;
	GameObject obj;

	void Start () 
	{
		obj = gameObject.CreatePrimitive (primitiveType);
	}

	void Update () 
	{
	}
		
	public enum PrimitiveType
	{
		Sphere, Capsule, Cilinder, Cube, Plane
	}
}
