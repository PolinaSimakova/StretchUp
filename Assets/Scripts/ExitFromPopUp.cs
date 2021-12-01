using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitFromPopUp : MonoBehaviour
{
    [SerializeField] private GameObject aboutAs;
    [SerializeField] private GameObject warmUpPopUp;
    [SerializeField] private GameObject workoutsPopUp; 
    [SerializeField] private GameObject workoutPopUp; 
    void Update()
    {
        toExitFromPopUp(aboutAs, warmUpPopUp, workoutsPopUp, workoutPopUp);
    }
    public void toExitFromPopUp(GameObject _aboutAs,GameObject _warmUpPopUp, GameObject _workoutsPopUp, GameObject _workoutPopUp) {
        if (Application.platform == RuntimePlatform.Android ||
            Application.platform == RuntimePlatform.WindowsEditor) {
            if (Input.GetKeyDown(KeyCode.Escape)) {
                if (_aboutAs.activeSelf || _warmUpPopUp.activeSelf || _workoutsPopUp.activeSelf || _workoutPopUp.activeSelf) {
                    SceneManager.LoadScene("Home");
                }else if (SceneManager.GetActiveScene().name == "Home" && !_aboutAs.activeSelf && !_warmUpPopUp.activeSelf && !_workoutsPopUp.activeSelf && !_workoutPopUp.activeSelf) {
                    Application.Quit();
                }
            }
        }
    }
}
