using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitAndroid : MonoBehaviour {
    void Update() {
        if (Application.platform == RuntimePlatform.Android ||
            Application.platform == RuntimePlatform.WindowsEditor) {
            if (Input.GetKeyDown(KeyCode.Escape)) {
                //Debug.Log(SceneManager.GetActiveScene().name);
                if (SceneManager.GetActiveScene().name == "Warm-upVideo") {
                    SceneManager.LoadScene("Warm-up"); // загружаете нужную сцену
                }else if (SceneManager.GetActiveScene().name == "WorkoutNew") {
                    SceneManager.LoadScene("Workouts"); // загружаете нужную сцену
                }
            }
        }
    }
}