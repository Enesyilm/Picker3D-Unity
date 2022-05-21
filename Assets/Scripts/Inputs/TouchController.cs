using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
   
    void Update()
    {
        if(Input.touchCount>0){
            Touch touchInput=Input.GetTouch(0);
            if(touchInput.deltaPosition.x >BasketMovement.swerveSensitivity||touchInput.deltaPosition.x <-BasketMovement.swerveSensitivity){
                GameState.currentGameState=GameState.GameStates.Continues;
                Destroy(gameObject);
                
            }
 
        }
        
    }
}
