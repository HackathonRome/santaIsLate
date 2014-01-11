using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public float timer;
	public GUIStyle style;

	public int ifwin;
	public int iflose;

	// Use this for initialization
	void Start () 
	{
		timer = 60.0f;
		ifwin = 0;
		iflose = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		//gameObject.rigidbody.AddTorque(Vector3.forward);

		//gameObject.transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		gameObject.rigidbody.AddForce(-gameObject.transform.localRotation.z * 100, 0, gameObject.transform.localRotation.x * 100);

		//gameObject.rigidbody.AddForce(Input.GetAxis("Horizontal") * 50, 0, Input.GetAxis("Vertical") * 50);
		gameObject.rigidbody.AddTorque(Input.GetAxis("Vertical") * 2, 0, -Input.GetAxis("Horizontal") * 2);
		//gameObject.rigidbody.AddTorque(Input.acceleration.x * 2, 0, 0);

		if(Input.GetKeyDown(KeyCode.W))
		   gameObject.rigidbody.AddForce(0, 300, 0);

		if(Input.GetKeyDown(KeyCode.S))
			gameObject.rigidbody.AddForce(0, -300, 0);

		if(Input.GetKeyDown(KeyCode.A))
			gameObject.rigidbody.AddForce(-300, 0, 0);

		if(Input.GetKeyDown(KeyCode.D))
			gameObject.rigidbody.AddForce(300, 0, 0);


		if(gameObject.transform.localRotation.z <= 0)
			gameObject.transform.Rotate(0, 0, 1);
		else
			gameObject.transform.Rotate(0, 0, -1);

		if(gameObject.transform.localRotation.x <= 0)
			gameObject.transform.Rotate(1, 0, 0);
		else
			gameObject.transform.Rotate(-1, 0, 0);

		if(gameObject.transform.localRotation.y <= 0)
			gameObject.transform.Rotate(0, 1, 0);
		else
			gameObject.transform.Rotate(0, -1, 0);

		timer -= Time.deltaTime;

		if(timer < 0 && ifwin != 1)
		{
			iflose = 1;
			GameObject.Find("LOSE").renderer.enabled = true;
		}

		Debug.Log(timer);
	}

	void OnGUI ()
	{
		GUI.Label (new Rect (12,0,100,50), "Santa is coming in: " + Mathf.Round (timer) + " seconds!", style);
		GUI.Label (new Rect (12,Screen.height - 50,100,50), "Speed: "+ Mathf.Round(rigidbody.velocity.magnitude / 2) + " MPs", style);
	}

	void OnTriggerEnter(Collider other) {
		ifwin = 1;
		GameObject.Find("WIN").renderer.enabled = true;
	}
}
