using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class URL : MonoBehaviour
{
    private List<String> listUrl = new List<string>();
    public string _urlVideo;
    [SerializeField]private Previews previews;
    private void Start() {
        toDoListUrlVideo();
        toSetUrlPreview();
    }

    private void Awake() {
        previews = GameObject.Find("Previews").GetComponent<Previews>();
    }

    void toDoListUrlVideo() {
        listUrl.Add("https://www.youtube.com/watch?v=OLkDiSPcjoU");
        listUrl.Add("https://www.youtube.com/watch?v=uwTmCOTyPAQ");
        listUrl.Add("https://www.youtube.com/watch?v=H2Zw8eTcAp4");
        listUrl.Add("https://www.youtube.com/watch?v=yhlNbOY0T7Y");
        listUrl.Add("https://www.youtube.com/watch?v=JcCaIhr2N2w");
        listUrl.Add("https://www.youtube.com/watch?v=V4jrZrlaYs8");
        listUrl.Add("https://www.youtube.com/watch?v=EAxIiL55oKk");
        listUrl.Add("https://www.youtube.com/watch?v=bLrbackYtgo");
        listUrl.Add("https://www.youtube.com/watch?v=14AOi9McPOE");
        listUrl.Add("https://www.youtube.com/watch?v=iJDfQjflUgg");
        listUrl.Add("https://www.youtube.com/watch?v=pEufssUMHYM");
        listUrl.Add("https://www.youtube.com/watch?v=wKFfvECKFr4");
        listUrl.Add("https://www.youtube.com/watch?v=gi5-okWTcjM");
        listUrl.Add("https://www.youtube.com/watch?v=kSJ3XdXwdg0");
        listUrl.Add("https://www.youtube.com/watch?v=smakFkx3DM8");
        listUrl.Add("https://www.youtube.com/watch?v=J-kTvGTPYiA");
        listUrl.Add("https://www.youtube.com/watch?v=belbKi-IP-A");
        listUrl.Add("https://www.youtube.com/watch?v=1QaizbbmixU");
        listUrl.Add("https://www.youtube.com/watch?v=U-ckMOSF2aM");
        listUrl.Add("https://www.youtube.com/watch?v=xP2TDbUvwYQ");
        listUrl.Add("https://www.youtube.com/watch?v=7X1qq3xv8lc");
        listUrl.Add("https://www.youtube.com/watch?v=nS__QgWC5ys"); //разминка
    }

    void toSetUrlPreview() {
        for (int i = 0; i < listUrl.Count; i++) {
            previews.listPreview[i].GetComponent<URL>()._urlVideo = listUrl[i];
        }
    }
    public void toSaveUrlVideo(string _sceneName) {
        DataHolder.urlVideo = _urlVideo;
        SceneManager.LoadScene(_sceneName);
    }
}
