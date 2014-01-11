using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

	public Transform prefab;

	// Use this for initialization
	void Start () 
	{
		for(int i = 0; i < 1500; i++)
		{
			Transform inst = (Transform)Instantiate(prefab, new Vector3(Random.Range(-5500, 5500), Random.Range(-3000, 3000), Random.Range(0, 20000)), Quaternion.identity);
			inst.transform.localScale = Vector3.one * Random.Range(10.0f, 350.0f);
			//inst.transform.localScale = new Vector3 (Random.Range(1.0f, 350.0f), Random.Range(1.0f, 350.0f), Random.Range(1.0f, 350.0f));
			inst.transform.localRotation = Quaternion.Euler(Random.Range(0.0f, 90.0f), Random.Range(0.0f, 90.0f), Random.Range(0.0f, 90.0f));
			inst.renderer.material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));

			//var randomHSV = new ColorHSV(Random.Range(0.0, 1.0), 1.0, 1.0);
			//var color = randomHSV.ToColor();
		}
	}
	
	// Update is called once per frame
	void Update () 
	{

	}
}
