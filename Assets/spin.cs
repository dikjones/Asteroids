using UnityEngine;
﻿using System.Collections;

public class spin : MonoBehaviour
{

	void Update ()
	{
		if (Input.GetKey(KeyCode.A))
	 	{
    		transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
		}

   if (Input.GetKey(KeyCode.D))
	 {
       transform.Rotate(-Vector3.up * Time.deltaTime);
			 }

  	}
}
