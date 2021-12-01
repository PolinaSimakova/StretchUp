using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScenesLoading : MonoBehaviour {
    private Scene scene;
    public string _urlVideo;
    public string _textButton;
    public void ChangeScene(string _sceneName) {
        
        SceneManager.LoadScene(_sceneName);
        
    }
    public void SaveUrlVideoAndTextButton(string _sceneName) {
        DataHolder.urlVideo = _urlVideo;
        DataHolder.textGeneral = _textButton;
        SceneManager.LoadScene(_sceneName);
    }
    public void Exit() {
        Application.Quit();
    }
}