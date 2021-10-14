using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Email : MonoBehaviour
{
    public void SendMail()
    {
        Application.OpenURL("mailto:vlad@htmlbook.ru?subject=Вопрос по HTML");
        //Application.OpenURL("mailto:example@gmail.com");
    }
}
