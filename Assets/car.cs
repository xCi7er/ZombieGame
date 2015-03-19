using UnityEngine;
using System.Collections;

public class car : MonoBehaviour {

	public WheelCollider wheelLeft;
	public WheelCollider wheelRight;
	public WheelCollider wheelBLeft;
	public WheelCollider wheelBright;

	public float speed = 15;
	public float breaking = 25;
	public float turning = 25;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		wheelBright.motorTorque = Input.GetAxis ("Vertical") * speed;
		wheelBLeft.motorTorque = Input.GetAxis ("Vertical") * speed;

		wheelBLeft.brakeTorque = 0;
		wheelBright.brakeTorque = 0;

		wheelLeft.steerAngle = Input.GetAxis ("Horizontal") * turning;
		wheelRight.steerAngle = Input.GetAxis ("Horizontal") * turning;

		if(Input.GetKey(KeyCode.Space))
		{
			wheelBLeft.brakeTorque = breaking;
			wheelBright.brakeTorque = breaking;
		}


	}
}
