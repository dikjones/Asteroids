using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	void Update () {

   if (Input.GetKey(KeyCode.A))
       transform.Rotate(Vector3.up * speed * Time.deltaTime);

   if (Input.GetKey(KeyCode.D))
       transform.Rotate(-Vector3.up * speed * Time.deltaTime);

  }
}

//test
