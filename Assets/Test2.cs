using UnityEngine;
using System.Collections;

public class Test2 : MonoBehaviour {
	// Update is called once per frame
	void Update()
	{
		Vector3 position = transform.position;
		position.y = Mathf.Sin(Time.time * 1f) * 10.0f;
		transform.position = position;
	}
}
