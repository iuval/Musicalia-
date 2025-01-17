﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	public float dampTime = 0.15f;
	private Vector3 velocity = Vector3.zero;
	public Transform target;
	
	// Update is called once per frame
	void Update () 
	{
		if (target)
		{
			Vector3 point = Camera.main.WorldToViewportPoint(target.position);
			Vector3 delta = target.position - Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
			Vector3 destination = transform.position + delta;
			if (destination.x <= 223.5819) {
				transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
			}
		}
		
	}
}
