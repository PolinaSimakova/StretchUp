using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationObject : MonoBehaviour {
    [Tooltip("Automatically activtae the object after delay.\n"
             + "If set to false object has to be activated by another script.\n"
             + "Can still be done delayed using 'ActivateDelayed()'")]
    [SerializeField]
    private bool ActivateOnStart = true;

    [SerializeField] private float ActivationDelay = 0.5f;

    [SerializeField] private GameObject[] GameObject;

    [SerializeField] private bool isDown = false;
    [SerializeField] private float time = 6;
    Coroutine coroutine;

    private void Awake() {
        coroutine = StartCoroutine("ExecuteAfterTime");
    }

    public void ShowObject() {
        if (ActivateOnStart) ActivateDelayed();

        StartCoroutine("ExecuteAfterTime");

        if (isDown) {
            StopCoroutine("ExecuteAfterTime");
            print(time);
            coroutine = StartCoroutine("ExecuteAfterTime");
        }
    }

    private void AfterDelay() {
        foreach (var VARIABLE in GameObject) {
            VARIABLE.SetActive(true);
        }
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

    //to the precision of a second
    IEnumerator ExecuteAfterTime() {
        yield return new WaitForSeconds(time);
        foreach (var VARIABLE in GameObject) {
            VARIABLE.SetActive(false);
        }
    }

    public void OnPointerDown() {
        isDown = true;
    }

    public void OnPointerUp() {
        isDown = false;
    }
}