using UnityEngine;
using TMPro;

public class LastJumpBlockChecker : MonoBehaviour
{

    [SerializeField] JumpBlock[] jumpBlocks;
    [SerializeField] TextMeshProUGUI gemAmountText;
    int maxindex=0;
    bool AlreadyWorked=false;
    
    void Update()
    {
        CheckAllBlocks();
        if(!AlreadyWorked&&GameState.currentGameState==GameState.GameStates.LevelFinished){
            AlreadyWorked=true;
            GameState.CurrentGemAmount += jumpBlocks[maxindex].pointAmount;
        }
        gemAmountText.text = "Gem: " + GameState.CurrentGemAmount.ToString();

    }

    private void CheckAllBlocks()
    {
        for (int index = 0; index < jumpBlocks.Length; index++)
        {
            jumpBlocks[index].pointAmount = index * 100;
            jumpBlocks[index].pointAmountText.text = jumpBlocks[index].pointAmount.ToString();
            if (jumpBlocks[index].isCollided)
            {
                maxindex = index;
            }
        }
    }
}
