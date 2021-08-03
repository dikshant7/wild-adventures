using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakableplatform : MonoBehaviour
{
  Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.name.Equals ("Player")) {
			Invoke ("DropPlatform", 1f);
			Destroy (gameObject, 2f);
		}
		FindObjectOfType<AudioManager>().Play("BreakAblePlatformSound");
	}

	void DropPlatform()
	{
		rb.isKinematic = false;
	}
}
