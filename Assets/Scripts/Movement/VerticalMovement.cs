using System;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    public enum BasketState{
        Stopped,
        Moving
    }
    public static BasketState currentBasketState=BasketState.Stopped;
    [SerializeField]float speed=3;
    [SerializeField]float extraSpeedByTap=1;
    [SerializeField]float IncreaseAmountByTap=0.5f;
    private void Awake() {
        extraSpeedByTap=2;
    }
    void FixedUpdate()
    {
        if(GameState.currentGameState==GameState.GameStates.Continues){
            DecideToBasketState();
        }

    }

    private void DecideToBasketState()
    {
        switch (currentBasketState)
        {
            case BasketState.Stopped:
                break;
            case BasketState.Moving:
                MoveBasket();
                break;
        }
    }


    private void MoveBasket()
    {
        
        
        if(FinalJump.IsFinalJumptriggered)
        {
            MoveDynamicOnFinalJump();

        }
        else
        {
            NormalMove();
        }


    }

    private void NormalMove()
    {
        float posZ = Mathf.Lerp(transform.position.z, transform.position.z + speed, Time.deltaTime * 1f);
        transform.localPosition = new Vector3(transform.position.x, transform.position.y, posZ);
    }

    private void MoveDynamicOnFinalJump()
    {
        ReduceSpeedByTime();
        float posZ = Mathf.Lerp(transform.position.z, transform.position.z + speed + extraSpeedByTap, Time.deltaTime * 1f);
        transform.localPosition = new Vector3(transform.position.x, transform.position.y, posZ);
        IncreaseSpeedByTap();
       
    }

    private void IncreaseSpeedByTap()
    {
        if (Input.touchCount > 0)
        {
            extraSpeedByTap+=IncreaseAmountByTap;
        }
    }

    private void ReduceSpeedByTime()
    {
       extraSpeedByTap= Mathf.Lerp(extraSpeedByTap, 0,.01f);
    }

    public static void ChangeBasketState(BasketState basketState){
        VerticalMovement.currentBasketState=basketState;
    }
    
}
