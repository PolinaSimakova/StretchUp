using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextGeneral : MonoBehaviour {
    public TextMeshProUGUI textGeneral;
    [SerializeField] private GameObject aboutAs;
    [SerializeField] private GameObject warmUpPopUp;
    [SerializeField] private GameObject workoutsPopUp;
    [SerializeField] private GameObject workoutPopUp;
    
    private void Update() {
        if (SceneManager.GetActiveScene().name == "Home") {
            toChangeTextGeneral(textGeneral, aboutAs, warmUpPopUp, workoutsPopUp, workoutPopUp);
        } else if (SceneManager.GetActiveScene().name == "WorkoutNew") {
            toCangeTextGeneralWorkout(textGeneral);
        }
    }

    private void toChangeTextGeneral(TextMeshProUGUI _textGeneral, GameObject _aboutAs,GameObject _warmUpPopUp, GameObject _workoutsPopUp, GameObject _workoutPopUp) {
        if (_aboutAs.activeSelf) {
            _textGeneral.text = "Описание";
        }else if (_workoutsPopUp.activeSelf || _workoutPopUp.activeSelf || _warmUpPopUp.activeSelf) {
            _textGeneral.text = "Руководство";
        }
        else {
            _textGeneral.text = "Главная";
        }
    }
    private void toCangeTextGeneralWorkout(TextMeshProUGUI _textGeneral) {
        _textGeneral.text = DataHolder.textGeneral;
    }
    
}
