using System.Collections;
using UnityEngine;

public class CheckIfJumped : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            StartCoroutine("Deneme");

        }
    }
    IEnumerator Deneme(){
        yield return new WaitForSeconds(2f);
        GameState.currentGameState=GameState.GameStates.LevelFinished;
        
    }
}
