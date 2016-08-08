using UnityEngine;
using System.Collections;

public class CamFollow : MonoBehaviour {

    public Transform target;
    public float scaleFactor = 1f;
    public float distance = -10f;
    public float speed = 0.1f;
    Camera cam;

	// Use this for initialization
	void Start () {

        cam = GetComponent<Camera>();

	}

	// Update is called once per frame
	void Update () {

        cam.orthographicSize = (Screen.height / 100f) / scaleFactor;
        transform.position = Vector3.Lerp(transform.position, target.position + new Vector3(0, 0, distance), speed);

	}
}