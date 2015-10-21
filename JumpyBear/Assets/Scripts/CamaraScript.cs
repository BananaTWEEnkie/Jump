using UnityEngine;
using System.Collections;

public class CamaraScript : MonoBehaviour {
  
  public GameObject player;
  
  // Update is called once per frame
  void Update () {
  
	this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x,player.gameObject.transform.position.y,this.gameObject.transform.position.z);

  }
 }