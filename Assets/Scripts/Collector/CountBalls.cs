using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountBalls : MonoBehaviour
{
    
    [SerializeField] int necessaryBallAmount=30;
    [SerializeField] TextMeshPro currentBallAmountText;
    [SerializeField]StopAtSelectedDistance stopAtSelectedDistance;
    ElevatePlatfromOnContinue elevatePlatfromOnContinue;
    AutoGateOpening autoGateOpening;
    int currentBallAmount=0;
    bool platformAlreadyElevated=false;

    private void Awake() {
        elevatePlatfromOnContinue=GetComponent<ElevatePlatfromOnContinue>();
        autoGateOpening=GetComponent<AutoGateOpening>();

        currentBallAmountText.text= currentBallAmount+"/"+necessaryBallAmount;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            currentBallAmount++;
            currentBallAmountText.text = currentBallAmount + "/" + necessaryBallAmount;
        }
        
        Invoke("CheckBallAmount",3f);
        
    }

    private void CheckBallAmount()
    {
        if (necessaryBallAmount > currentBallAmount)
        {
            GameState.currentGameState=GameState.GameStates.Failed;
        }
        else{
            
            
            if(platformAlreadyElevated==false){
                
                stopAtSelectedDistance.IncreaseDestinationIndex();
                elevatePlatfromOnContinue.ElevatePlatform();//
                platformAlreadyElevated=true;
            }
            autoGateOpening.IsGateOpened=true;
        }

    }
}
