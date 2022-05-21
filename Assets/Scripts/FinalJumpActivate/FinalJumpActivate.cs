using UnityEngine;

public class FinalJumpActivate : MonoBehaviour
{
    [SerializeField] BasketMovement basketMovement;
    [SerializeField] VerticalMovement verticalMovement;
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            FinalJump.IsFinalJumptriggered=true;
            verticalMovement.enabled=false;
            basketMovement.enabled=false;
            VerticalMovement.currentBasketState=VerticalMovement.BasketState.Stopped;

        }
    }
}
