using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Test : MonoBehaviour {
    [Tooltip("Automatically activtae the object after delay.\n"
             + "If set to false object has to be activated by another script.\n"
             + "Can still be done delayed using 'ActivateDelayed()'")]
    public bool ActivateOnStart = true;

    public float ActivationDelay = 0.5f;
    public GameObject GameObject;

    public bool isDown = false;
    public float time = 6;
    Coroutine myCoroutine;

    private void Awake() {
        myCoroutine = StartCoroutine("ExecuteAfterTime");
    }

    public void Show() {
       // OnPointerDown();

        if (ActivateOnStart) ActivateDelayed();

        StartCoroutine("ExecuteAfterTime");

        if (isDown) {
            StopCoroutine("ExecuteAfterTime");
            print(time);
            myCoroutine = StartCoroutine("ExecuteAfterTime");
        }
    }

    private void AfterDelay() {
        GameObject.SetActive(true);
    }

    /*
     * Activates the object after the configured delay
     */
    public void ActivateDelayed() {
        Invoke(nameof(AfterDelay), ActivationDelay);
    }

    /*
     * Activates the object after the passed custom delay
     */
    public void ActivateDelayed(float customDelay) {
        Invoke(nameof(AfterDelay), customDelay);
    }

    //точность до секунды
    IEnumerator ExecuteAfterTime() {
        yield return new WaitForSeconds(time);
        GameObject.SetActive(false);
    }

    public void OnPointerDown() {
        isDown = true;
    }

    public void OnPointerUp() {
        isDown = false;
    }
}