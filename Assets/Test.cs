using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = transform.position;
		position.x = Mathf.Cos(Time.time * 1f) * 10.0f;
		transform.position = position;
	}
}
