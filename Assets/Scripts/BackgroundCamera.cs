using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundCamera : MonoBehaviour {
    [SerializeField] private GameObject PanelGO;

    void Update() {
        if (Screen.orientation == ScreenOrientation.Portrait && !PanelGO.activeSelf) {
            Camera.main.backgroundColor = new Color(255, 255, 255);
            PanelGO.SetActive(true);
        }

        if (Screen.orientation == ScreenOrientation.LandscapeLeft ||
            Screen.orientation == ScreenOrientation.LandscapeRight && PanelGO.activeSelf) {
            Camera.main.backgroundColor = new Color(0, 0, 0);
            PanelGO.SetActive(false);
        }
    }
}