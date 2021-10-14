using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoScale : MonoBehaviour {
    private float newObjectWidth;
    private float oldObjectWidth;

    private void Awake() {
        oldObjectWidth = transform.localScale.x;
        newObjectWidth = oldObjectWidth * 13.0f / 6.0f * Screen.width / Screen.height;
        transform.localScale = new Vector2(newObjectWidth,transform.localScale.y );
    }
}
