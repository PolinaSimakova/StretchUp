using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PopUp : MonoBehaviour {
    [SerializeField] GameObject popUpWindow;
    [SerializeField] GameObject[] popUpsWindow;
    [SerializeField] private GameObject buttonForward;

    public void clicked(Button _button) {
        if (_button == true) {
            popUpWindow.SetActive(true);
        }
    }
    
    public void clouse() {
        popUpWindow.SetActive(false);
    }
    
    public void clouseAll() {
        for (int i = 0; i < popUpsWindow.Length; i++) {
            popUpsWindow[i].SetActive(false);
        }
    }

    public void SetActivePopUp() {
        popUpWindow.SetActive(true);
        if (popUpsWindow[popUpsWindow.Length - 1].activeSelf) {
            while (GameObject.Find("ForwardContinueButton")) {
                GameObject.Find("ForwardContinueButton").SetActive(false);
            }
        }
    }

    public void SetActiveButtonForward() {
        if (popUpsWindow[0].activeSelf || popUpsWindow[1].activeSelf && popUpsWindow[popUpsWindow.Length - 1].activeSelf == false) {
            buttonForward.SetActive(true);
        }
    }
}