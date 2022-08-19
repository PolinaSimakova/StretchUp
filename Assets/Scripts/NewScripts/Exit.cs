using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Exit : MonoBehaviour
{
    void Update() {
        exitToPreviousScene();
    }
    
    private void exitToPreviousScene() {
        if (Application.platform == RuntimePlatform.Android ||
            Application.platform == RuntimePlatform.WindowsEditor) {
            if (Input.GetKeyDown(KeyCode.Escape)) {
                if (SceneManager.GetActiveScene().name == "Player") {
                    SceneManager.LoadScene("Workouts"); // загружаете нужную сцену
                }
            }
        }
    }
}
