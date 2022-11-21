using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Previews : MonoBehaviour
{
    public List<GameObject> listPreview = new List<GameObject>();
    [SerializeField] private GameObject PREVIEW;
    [SerializeField] private List<Sprite> previewSourceImageList;

    private int countPreview = 22;

    public String lessonTitle;

    private Translation translation;

    private void Start() {
        toInstantiatePreview();
        setNameWarmUp();
    }

    public void toInstantiatePreview() {
        for (int i = 0; i < countPreview; i++) {
            GameObject newCreatePreview;
            newCreatePreview = Instantiate(PREVIEW, transform);

            lessonTitle = (i+1).ToString();
            newCreatePreview.name = "Workout " + lessonTitle; //имя объекта
            newCreatePreview.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = newCreatePreview.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text + lessonTitle; //текстовое поле объекта
            listPreview.Add(newCreatePreview);
            
            translation = listPreview[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().GetComponent<Translation>();
            translation.numberWorkout = lessonTitle;

            listPreview[i].transform.GetChild(0).GetComponent<Image>().sprite = previewSourceImageList[i];
        }
    }

    void setNameWarmUp() {
        String warmUpTitle = "Warm-up";
        listPreview.Last().transform.GetChild(1).GetComponent<LocalizeStringEvent>().StringReference.TableEntryReference = warmUpTitle;
    }

}
