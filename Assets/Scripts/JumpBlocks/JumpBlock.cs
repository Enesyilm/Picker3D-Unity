using UnityEngine;
using TMPro;

public class JumpBlock : MonoBehaviour
{
    [SerializeField] public int pointAmount=100;
    public bool isCollided=false;
    [SerializeField] public TextMeshPro pointAmountText;
    
    private void Awake() {
        pointAmountText.text=pointAmount.ToString();
    }
    private void OnTriggerEnter(Collider hit) {
        if(hit.CompareTag("Player")){
            
            isCollided=true;
        }
    }
}
