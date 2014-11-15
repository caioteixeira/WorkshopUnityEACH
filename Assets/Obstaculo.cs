using UnityEngine;
using System.Collections;

public class Obstaculo : MonoBehaviour {

	public Vector2 velocity = new Vector2(-4, 0);

	void Start () {
		rigidbody2D.velocity = this.velocity;
	}
	
	void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
}
