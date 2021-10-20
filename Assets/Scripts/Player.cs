using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using YoutubePlayer;

namespace YoutubePlayer {
    public class Player : MonoBehaviour {
        private VideoPlayer VideoPlayer;
        [SerializeField] private GameObject GameObjectVideoPlayer;
        [SerializeField] private GameObject LoadingText;

        [SerializeField] private Material MaterialPlay;
        [SerializeField] private Material MaterialPause;
        private Button buttonPlay;
        private string _urlVideo;

        private void Awake() {
            YoutubeDl.ServerUrl = "https://stretchup3.herokuapp.com";
            VideoPlayer = GameObjectVideoPlayer.GetComponent<VideoPlayer>();
            buttonPlay = GetComponent<Button>();
            _urlVideo = DataHolder.urlVideo;
        }

        private void Play(string url) {
            if (!VideoPlayer.isPlaying && VideoPlayer.url == "") {
                VideoPlayer.PlayYoutubeVideoAsync(url);
            }
            if (VideoPlayer.isPlaying) {
                VideoPlayer.Pause();
                buttonPlay.image.material = MaterialPlay;
            }
            else {
                VideoPlayer.Play();
                buttonPlay.image.material = MaterialPause;
            }
        }
        
        public void onDown() {
            Play(_urlVideo);
            if (!VideoPlayer.isPlaying) {
                LoadingText.SetActive(true);
            }
        }
        
        public void Repeat() {
            VideoPlayer.PlayYoutubeVideoAsync(_urlVideo);
            GameObject.Find("PlayButton").GetComponent<Button>().image.material = MaterialPause;
            if (!VideoPlayer.isPlaying) {
                LoadingText.SetActive(true);
            }
        }

        private void Update() {
            if (VideoPlayer.isPlaying){
                Debug.Log("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
                LoadingText.SetActive(false);
            }
        }
    }
}