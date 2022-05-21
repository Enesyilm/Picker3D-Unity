using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject levelFailedUI;
    [SerializeField] GameObject nextLevelUI;
    private void Awake()
    {
        InitializeLevelPrefs();
    }

    private static void InitializeLevelPrefs()
    {
        if (!PlayerPrefs.HasKey("currentLevel"))
        {
            PlayerPrefs.SetInt("currentLevel", 0);

        }
    }

    private void Update() {
       if(GameState.currentGameState==GameState.GameStates.Failed){

           levelFailedUI.SetActive(true);
       }
       if(GameState.currentGameState==GameState.GameStates.LevelFinished){
           nextLevelUI.SetActive(true);
       }
   }
   public void OnClickRetryButton(){
       levelFailedUI.SetActive(false);
       FinalJump.IsFinalJumptriggered=false;
       GameState.currentGameState=GameState.GameStates.NotStarted;
       SceneManager.LoadScene(PlayerPrefs.GetInt("currentLevel"));
   }
   public void OnClickNextButton(){
       nextLevelUI.SetActive(false);
       FinalJump.IsFinalJumptriggered=false;
       GameState.currentGameState=GameState.GameStates.NotStarted;
       Debug.Log("PlayerPrefs.GetInt(currentLevel)"+PlayerPrefs.GetInt("currentLevel"));
       if(PlayerPrefs.GetInt("currentLevel")+1<GameState.MaxLevelNumber){
        PlayerPrefs.SetInt("currentLevel",PlayerPrefs.GetInt("currentLevel")+1);
        Debug.Log("PlayerPrefs.GetInt(currentLevel)if"+PlayerPrefs.GetInt("currentLevel"));

       }
       else{
           PlayerPrefs.SetInt("currentLevel",0);
           Debug.Log("PlayerPrefs.GetInt(currentLevel)else"+PlayerPrefs.GetInt("currentLevel"));
       }
       SceneManager.LoadScene(PlayerPrefs.GetInt("currentLevel"));
   }
}
