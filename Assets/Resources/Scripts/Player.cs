using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public float Speed = 800.0f;
	public Rigidbody Rb;
		
	void Start () {
		Rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		Rb.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime * Speed, 0, 0);
	}
}
