using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour {
    [SerializeField] private GameObject prefabDayButton;

    public List<GameObject> prefabDayButtonList;
    //[SerializeField] private GameObject text;

    private int countDays = 21;
    
    public List<string> urlVideoList = new List<string>();

    private void Start() {
        addUrlToArray();
        Populate();
    }

    void Populate() {
        GameObject newCreateButton;
        GameObject newCreateText;
        for (int i = 0; i < countDays; i++) {
            newCreateButton = Instantiate(prefabDayButton, transform);
            prefabDayButtonList.Add(prefabDayButton);
            newCreateButton.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = (i + 1) +  " День";
           // Debug.Log(newCreateButton.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text);

            newCreateButton.GetComponent<ScenesLoading>()._urlVideo =
                urlVideoList[i];

            //newCreateButton.GetComponentInChildren<TextMeshPro>().text = (i + 1).ToString();
            // text.text = (i + 1) +  " День";
            //newCreateButton.text.GetComponent<Text>().text = (i + 1) +  " День";
        }
    }
    
    private void addUrlToArray() {
        //urlVideoList.Add("https://www.youtube.com/watch?v=OLkDiSPcjoU");
        urlVideoList.Add("https://www.youtube.com/watch?v=ZbwTN1Dwlu4");
        urlVideoList.Add("https://www.youtube.com/watch?v=uwTmCOTyPAQ");
        urlVideoList.Add("https://www.youtube.com/watch?v=H2Zw8eTcAp4");
        urlVideoList.Add("https://www.youtube.com/watch?v=yhlNbOY0T7Y");
        urlVideoList.Add("https://www.youtube.com/watch?v=JcCaIhr2N2w");
        urlVideoList.Add("https://www.youtube.com/watch?v=V4jrZrlaYs8");
        urlVideoList.Add("https://www.youtube.com/watch?v=EAxIiL55oKk");
        urlVideoList.Add("https://www.youtube.com/watch?v=bLrbackYtgo");
        urlVideoList.Add("https://www.youtube.com/watch?v=14AOi9McPOE");
        urlVideoList.Add("https://www.youtube.com/watch?v=iJDfQjflUgg");
        urlVideoList.Add("https://www.youtube.com/watch?v=pEufssUMHYM");
        urlVideoList.Add("https://www.youtube.com/watch?v=wKFfvECKFr4");
        urlVideoList.Add("https://www.youtube.com/watch?v=gi5-okWTcjM");
        urlVideoList.Add("https://www.youtube.com/watch?v=kSJ3XdXwdg0");
        urlVideoList.Add("https://www.youtube.com/watch?v=smakFkx3DM8");
        urlVideoList.Add("https://www.youtube.com/watch?v=J-kTvGTPYiA");
        urlVideoList.Add("https://www.youtube.com/watch?v=belbKi-IP-A");
        urlVideoList.Add("https://www.youtube.com/watch?v=1QaizbbmixU");
        urlVideoList.Add("https://www.youtube.com/watch?v=U-ckMOSF2aM");
        urlVideoList.Add("https://www.youtube.com/watch?v=xP2TDbUvwYQ");
        urlVideoList.Add("https://www.youtube.com/watch?v=7X1qq3xv8lc");
    }
}
