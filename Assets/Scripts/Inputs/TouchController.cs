using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    [SerializeField]SwerveInputSystem  swerveInputSystem;
   private void Awake()
    {
        //swerveInputSystem = GetComponent<SwerveInputSystem>();
    }
    void Update()
    {
         
        if(Input.GetMouseButton(0)){
            if(swerveInputSystem.MoveFactorX >5||swerveInputSystem.MoveFactorX <-5){
                 GameState.currentGameState=GameState.GameStates.Continues;
                 Destroy(gameObject);
            }
 
        }
        
    }
}
