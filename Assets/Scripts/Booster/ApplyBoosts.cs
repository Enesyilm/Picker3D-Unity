using UnityEngine;

public class ApplyBoosts : MonoBehaviour
{
    float  passedTime=0;
    [SerializeField] GameObject boosterObject;
    void Update()
    {
        if(GameState.PlayerHaveBoost){
            
            ApplyTheBoost(GameState.CurrentBoostDuration);

        }
    }

    private void ApplyTheBoost(float timeLimit)
    {
        if (!CountTime(timeLimit))
        {
            
            boosterObject.SetActive(true);
        }
        else
        {
            GameState.PlayerHaveBoost=false;
            boosterObject.SetActive(false);
        }
    }

    private bool CountTime(float timeLimit)
    {
        
        if (passedTime < timeLimit)
        {
            passedTime += Time.deltaTime;
            return false;
        }
        else{
            passedTime=0;
            return true;
        }
    }
}
