using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitAndroid : MonoBehaviour
{
    void Update ()
    {
        if (Application.platform == RuntimePlatform.Android ||
            Application.platform == RuntimePlatform.WindowsEditor)
        {
            if (Input.GetKeyDown (KeyCode.Escape))
            {
                // аналогично для float или string, но пишите SetFloat или SetString
                PlayerPrefs.SetInt ("Тут ключ, на который сохраняются значения", 42); // 42 - тут любое int, какое хотите сохранить
                // все, что нужно сохранить
                SceneManager.LoadScene ("Workouts"); // загружаете нужную сцену
            }
        }
    }
}
