using UnityEngine;
﻿using System.Collections;

public class Spin : MonoBehaviour
{

	void Update ()
	{
		if (Input.GetKey(KeyCode.A))
	 	{
    		transform.Rotate(Vector3.right * Time.deltaTime);
		}

   if (Input.GetKey(KeyCode.D))
	 {
       transform.Rotate(-Vector3.right * Time.deltaTime);
			 }

  	}
}
