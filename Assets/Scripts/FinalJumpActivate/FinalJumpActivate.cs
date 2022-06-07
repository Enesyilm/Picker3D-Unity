using UnityEngine;

public class FinalJumpActivate : MonoBehaviour
{
    [SerializeField] VerticalMovement verticalMovement;
    [SerializeField] SwerveInputSystem swerveInputSystem;
    [SerializeField] GameObject jumpInfoText;
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            FinalJump.IsFinalJumptriggered=true;
            verticalMovement.enabled=false;
            swerveInputSystem.enabled=false;
            jumpInfoText.SetActive(true);
            VerticalMovement.currentBasketState=VerticalMovement.BasketState.Stopped;

        }
    }
}
