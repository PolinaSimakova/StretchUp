using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScenesLoading : MonoBehaviour {
    public List<string> urlVideo = new List<string>();
    private Scene scene;

    [SerializeField] private GameObject quadRenderer;
    [SerializeField] private Texture[] textures;

    public string _urlVideo;

    /*private void Start() {
        addUrlToArray();
    }*/

    private void Awake() {
        //ToChangeTexture();
       // addUrlToArray();
    }
    private void addUrlToArray() {
        urlVideo.Add("https://youtu.be/OLkDiSPcjoU");
        urlVideo.Add("https://youtu.be/uwTmCOTyPAQ");
        urlVideo.Add("https://youtu.be/H2Zw8eTcAp4");
        urlVideo.Add("https://youtu.be/yhlNbOY0T7Y");
        urlVideo.Add("https://youtu.be/JcCaIhr2N2w");
        urlVideo.Add("https://youtu.be/V4jrZrlaYs8");
        urlVideo.Add("https://youtu.be/EAxIiL55oKk");
        urlVideo.Add("https://youtu.be/bLrbackYtgo");
        urlVideo.Add("https://youtu.be/14AOi9McPOE");
        urlVideo.Add("https://youtu.be/iJDfQjflUgg");
        urlVideo.Add("https://youtu.be/pEufssUMHYM");
        urlVideo.Add("https://youtu.be/wKFfvECKFr4");
        urlVideo.Add("https://youtu.be/gi5-okWTcjM");
        urlVideo.Add("https://youtu.be/kSJ3XdXwdg0");
        urlVideo.Add("https://youtu.be/smakFkx3DM8");
        urlVideo.Add("https://youtu.be/J-kTvGTPYiA");
        urlVideo.Add("https://youtu.be/belbKi-IP-A");
        urlVideo.Add("https://youtu.be/1QaizbbmixU");
        urlVideo.Add("https://youtu.be/U-ckMOSF2aM");
        urlVideo.Add("https://youtu.be/xP2TDbUvwYQ");
        urlVideo.Add("https://youtu.be/7X1qq3xv8lc");
    }

    void ToChangeTexture() {
        scene = SceneManager.GetActiveScene();
        //Texture textureVideo = quadRenderer.GetComponent<MeshRenderer>().material.mainTexture;
        if (scene.name == "Workout_1") {
            quadRenderer.GetComponent<MeshRenderer>().material.mainTexture = textures[0];
        }
        else if (scene.name == "Workout_2") {
            quadRenderer.GetComponent<MeshRenderer>().material.mainTexture = textures[1];
        }
        else if (scene.name == "Workout_3") {
            quadRenderer.GetComponent<MeshRenderer>().material.mainTexture = textures[2];
        }
        else if (scene.name == "Workout_4") {
            quadRenderer.GetComponent<MeshRenderer>().material.mainTexture = textures[3];
        }
        else if (scene.name == "Workout_5") {
            quadRenderer.GetComponent<MeshRenderer>().material.mainTexture = textures[4];
        }
        else if (scene.name == "Workout_6") {
            quadRenderer.GetComponent<MeshRenderer>().material.mainTexture = textures[5];
        }
        else if (scene.name == "Workout_7") {
            quadRenderer.GetComponent<MeshRenderer>().material.mainTexture = textures[6];
        }
        else if (scene.name == "Workout_8") {
            quadRenderer.GetComponent<MeshRenderer>().material.mainTexture = textures[7];
        }
        else if (scene.name == "Workout_9") {
            quadRenderer.GetComponent<MeshRenderer>().material.mainTexture = textures[8];
        }
        else if (scene.name == "Workout_10") {
            quadRenderer.GetComponent<MeshRenderer>().material.mainTexture = textures[9];
        }
        else if (scene.name == "Workout_11") {
            quadRenderer.GetComponent<MeshRenderer>().material.mainTexture = textures[10];
        }
        else if (scene.name == "Workout_12") {
            quadRenderer.GetComponent<MeshRenderer>().material.mainTexture = textures[11];
        }
        else if (scene.name == "Workout_13") {
            quadRenderer.GetComponent<MeshRenderer>().material.mainTexture = textures[12];
        }
        else if (scene.name == "Workout_14") {
            quadRenderer.GetComponent<MeshRenderer>().material.mainTexture = textures[13];
        }
        else if (scene.name == "Workout_15") {
            quadRenderer.GetComponent<MeshRenderer>().material.mainTexture = textures[14];
        }
        else if (scene.name == "Workout_16") {
            quadRenderer.GetComponent<MeshRenderer>().material.mainTexture = textures[15];
        }
        else if (scene.name == "Workout_17") {
            quadRenderer.GetComponent<MeshRenderer>().material.mainTexture = textures[16];
        }
        else if (scene.name == "Workout_18") {
            quadRenderer.GetComponent<MeshRenderer>().material.mainTexture = textures[17];
        }
        else if (scene.name == "Workout_19") {
            quadRenderer.GetComponent<MeshRenderer>().material.mainTexture = textures[18];
        }
        else if (scene.name == "Workout_20") {
            quadRenderer.GetComponent<MeshRenderer>().material.mainTexture = textures[19];
        }
        else if (scene.name == "Workout_21") {
            quadRenderer.GetComponent<MeshRenderer>().material.mainTexture = textures[20];
        }
        else if (scene.name == "Warm-up") {
            quadRenderer.GetComponent<MeshRenderer>().material.mainTexture = textures[21];
        }
    }

    public void ChangeScene(string _sceneName) {
        SceneManager.LoadScene(_sceneName);
    }

    public void ChangeUrlVideo(string _sceneName) {
        DataHolder.urlVideo = _urlVideo;
        SceneManager.LoadScene(_sceneName);
    }

    public void Exit() {
        Application.Quit();
    }
}