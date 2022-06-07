using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject levelFailedUI;
    [SerializeField] GameObject nextLevelUI;

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
       if(PlayerPrefs.GetInt("currentLevel")+1<GameState.MaxLevelNumber)
        {
            IncreaseCurrentLevel();

        }
        else
        {
           PlayerPrefs.SetInt("currentLevel",0);
       }
        SceneManager.LoadScene(PlayerPrefs.GetInt("currentLevel"));
    }

    private static void IncreaseCurrentLevel()
    {
        PlayerPrefs.SetInt("currentLevel", PlayerPrefs.GetInt("currentLevel") + 1);
    }
}
