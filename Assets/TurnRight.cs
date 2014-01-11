using UnityEngine;
using System.Collections;

public class TurnRight : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
		//player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		/*if (Input.GetMouseButtonDown(0))
		{
			var ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit, 100)) 
			{
				player.rigidbody.AddTorque(0, 0, 1);
				Debug.Log("AAA");
			}
		}*/
	}

	/*void OnMouseDown ()
	{
		player.rigidbody.AddTorque(0, 0, 1);
		Debug.Log("AAA");
	}*/
}
