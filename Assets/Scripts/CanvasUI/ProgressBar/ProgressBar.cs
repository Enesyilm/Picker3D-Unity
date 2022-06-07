using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI currentLevelText;
    [SerializeField] TextMeshProUGUI nextLevelText;
    [SerializeField] GameObject collectorList;
    [SerializeField] GameObject progressBar;
    [SerializeField] GameObject progressBarItem;
    float ProgressValue=0;
    // Start is called before the first frame update
    private void Awake() {
        if(PlayerPrefs.HasKey("currentLevel")){
            currentLevelText.text=PlayerPrefs.GetInt("currentLevel").ToString();
            nextLevelText.text=(PlayerPrefs.GetInt("currentLevel")+1).ToString();
        }
        else{
            PlayerPrefs.SetInt("currentLevel",0);
            currentLevelText.text=PlayerPrefs.GetInt("currentLevel").ToString();
            nextLevelText.text=(PlayerPrefs.GetInt("currentLevel")+1).ToString();
        }
    }
    void Start()
    {
        InitAllBarItems();
    }

    private void InitAllBarItems()
    {
        for (int index = 1; index < collectorList.transform.childCount; index++)
        {
            Instantiate(progressBarItem,progressBar.transform);

        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateProgressBar()
    {
        ProgressValue++;
        for (int index = 0; index < ProgressValue; index++)
        {
            Image ProgressItemImage = progressBar.transform.GetChild(index).GetComponent<Image>();
            ProgressItemImage.color = Color.red;
        }
        
    }
}
