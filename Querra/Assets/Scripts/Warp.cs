using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour {

    public Transform warpTarget;

    IEnumerator OnTriggerEnter2D (Collider2D collidingObject) {

        FadeBehaviour fader = GameObject.FindGameObjectWithTag("Fader").GetComponent<FadeBehaviour>();
        PlayerMovement movement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();


        movement.enabled = false;
        yield return StartCoroutine(fader.FadeOut());

        collidingObject.gameObject.transform.position = warpTarget.position;
        Camera.main.transform.position = warpTarget.position;

        yield return StartCoroutine(fader.FadeIn());
        movement.enabled = true;
    }
}