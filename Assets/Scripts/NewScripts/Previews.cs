using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Previews : MonoBehaviour
{
    public List<GameObject> listPreview = new List<GameObject>();
    [SerializeField] private GameObject PREVIEW;
    [SerializeField] private List<Sprite> previewSourceImageList;

    private int countPreview = 22;

    private void Start() {
        toInstantiatePreview();
        setNameWarmUp();
    }

    void toInstantiatePreview() {
        GameObject newCreatePreview;
        for (int i = 0; i < countPreview; i++) {
            newCreatePreview = Instantiate(PREVIEW, transform);
            listPreview.Add(newCreatePreview);

            String lessonTitle = "Workout " + (i + 1);
            
            newCreatePreview.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = lessonTitle;
            newCreatePreview.name = lessonTitle;
            
            listPreview[i].transform.GetChild(0).GetComponent<Image>().sprite = previewSourceImageList[i];
        }
    }

    void setNameWarmUp() {
        String warmUpTitle = "Warm-up";
        listPreview.Last().transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = warmUpTitle;
    }

}
