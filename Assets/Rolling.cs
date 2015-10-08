using UnityEngine;
using System.Collections;

public class Rolling : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		Vector3 angles = transform.eulerAngles;
		angles.z = 360.0f * Mathf.Sin(Time.time * 1.0f);
		transform.eulerAngles = angles;
	}
}
