using UnityEngine;
using System.Collections;

public class FlowerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.name == "Player")
		{
			Destroy(gameObject);
		}
	}
}
