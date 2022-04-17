using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    public bool start = false;
    public AnimationCurve curve;
    public float duration = 1f;

    void Update() {
        if (start) {
            start = true;
            StartCoroutine(Shaking());
        }
    }

    public void startShake(){
        StartCoroutine(Shaking());
    }

    IEnumerator Shaking() { 
        Vector3 startPosition = transform.position;
        float elapsedTime = 0f;

        while (elapsedTime < duration) {
            elapsedTime += Time.deltaTime;
            float strength = curve.Evaluate(elapsedTime / duration);
            transform.position = startPosition + Random.insideUnitSphere * strength;
            yield return null;
        }
        start = false;
        transform.position = startPosition;
    }
}
