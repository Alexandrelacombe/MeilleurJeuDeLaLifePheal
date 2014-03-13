using UnityEngine;
using System.Collections;

public class Flotaison : MonoBehaviour {
	public float hoverForce = 12f;
	void OnTriggerStay (Collider other) {
		other.rigidbody.AddForce (Vector3.up * hoverForce, ForceMode.Acceleration);
	}
}
