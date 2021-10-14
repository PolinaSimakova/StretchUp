using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class Track : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
   // [SerializeField] private AudioSource audio;
   // [SerializeField] private Slider audioVolume;
    [SerializeField] private VideoPlayer video;
    
    private Slider tracking;
    private bool slide = false;
    void Start() {
        tracking = GetComponent<Slider>();
    }

    public void OnPointerDown(PointerEventData eventData) {
        slide = true;
    }

    public void OnPointerUp(PointerEventData eventData) {
        float frame = (float)tracking.value * (float)video.frameCount;
        video.frame = (long) frame;
        slide = false;
    }

    void Update() {
        if (!slide && video.isPlaying) {
            tracking.value = (float)video.frame / (float)video.frameCount;
        }
    }

    /*public void Volume() {
        audio.volume = audioVolume.value;
    }*/
}
