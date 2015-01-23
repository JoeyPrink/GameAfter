using UnityEngine;
using System.Collections;

public class camerafollow : MonoBehaviour {

	public GameObject player;
	public float offsetX = 0f;
	public float offsetY = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 playerpos = new Vector3(player.transform.position.x + offsetX, player.transform.position.y + offsetY,-10);
		this.transform.position=playerpos;


	}
}
