using UnityEngine;

public class StopAtSelectedDistance : MonoBehaviour
{
    [SerializeField] float stopThreshold;
    public Transform[] destinationList;
    public int currentDestination=0;
   
    void FixedUpdate()
    {
        DecideToState();
    }

    private void DecideToState()
    {
        if (currentDestination == destinationList.Length)
        {
            GameState.currentGameState = GameState.GameStates.LevelFinished;
        }
        else if ((destinationList[currentDestination].position.z - transform.position.z) < stopThreshold)
        {
            VerticalMovement.ChangeBasketState(VerticalMovement.BasketState.Stopped);

        }
        else
        {
            VerticalMovement.ChangeBasketState(VerticalMovement.BasketState.Moving);
        }
    }

    public void IncreaseDestinationIndex(){
        if(destinationList.Length>currentDestination+1){
            currentDestination++;   
        }
    }
    
}
