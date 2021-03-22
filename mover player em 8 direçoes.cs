//Mover player em 8 direçoes simples
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour 
{
	public float Speed;
	Rigidbody Rig;

	void Start()
	{
		Rig = GetComponent<Rigidbody>();
	}	

	void FixedUpdate()
	{
		Vector3 Position = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		Rig.velocity = Position * Speed;
	}
}