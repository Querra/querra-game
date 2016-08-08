using UnityEngine;
using System.Collections;

public class FadeBehaviour : MonoBehaviour {

    Animator animator;
    bool isFading = false;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}

    public IEnumerator FadeIn () {
        isFading = true;
        animator.SetTrigger("FadeIn");

        while (isFading) {
            yield return null;
        }
    }

    public IEnumerator FadeOut () {
        isFading = true;
        animator.SetTrigger("FadeOut");

        while (isFading) {
            yield return null;
        }
    }

    void AnimationComplete () {
        isFading = false;
    }
}