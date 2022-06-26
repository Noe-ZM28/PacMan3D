
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
	public float velocity = 10f;
	public float time_speed = 0f;
	
	GameObject a;
	

	//time_speed = velocity * Time.deltaTime;
	// Start is called before the first frame update
	void Start(){}
	// Update is called once per frame
	void Update()
	{
		transform.rotation = new Vector3(0,0,0);

		if (Input.GetKey(KeyCode.D))
		{
			transform.position += new Vector3(velocity, 0, 0);
		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.position += new Vector3(-velocity, 0, 0);
		}
		if (Input.GetKey(KeyCode.W))
		{
			transform.position += new Vector3(0, 0, velocity);
		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.position += new Vector3(0, 0, -velocity);
		}

	}
}
