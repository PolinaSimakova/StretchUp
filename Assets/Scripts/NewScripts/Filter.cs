using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class Filter : MonoBehaviour {
    [SerializeField]private Previews previews;
    List<GameObject> intialPreviewList;
    private int activePreviwCount = 0;
    
    [SerializeField] private InputField searchField;
    
    [SerializeField] private GameObject filterGameObject;
    [SerializeField] private GameObject searchFieldGameObject;
    
    private void Start() {
        intialPreviewList = previews.GetComponent<Previews>().listPreview;
    }
    
    public void filterPreviewList(string keyWord) {

        keyWord = searchField.text;
        for (int i = 0; i < intialPreviewList.Count; i++) {
            if (intialPreviewList[i] != null) {
                intialPreviewList[i].SetActive(intialPreviewList[i].name.IndexOf(keyWord) >= 0);
            }

            if (intialPreviewList[i].activeSelf) {
                activePreviwCount++;
            }
        }
        previews.GetComponent<GridLayoutGroup>().constraintCount = activePreviwCount;
        activePreviwCount = 0;
    }
    public void setActiveSearchField() {
        filterGameObject.SetActive(false);
        searchFieldGameObject.SetActive(true);
    }

    public void setActiveFilter() {
        filterGameObject.SetActive(true);
        searchFieldGameObject.SetActive(false);
    }
}
