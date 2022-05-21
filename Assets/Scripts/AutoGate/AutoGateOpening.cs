using UnityEngine;
using DG.Tweening;

public class AutoGateOpening : MonoBehaviour
{
    [SerializeField] GameObject autoGate1;
    [SerializeField] GameObject autoGate2;
    [SerializeField] float openingAngle=50f;
    [SerializeField] float movementDuration=3f;


    public bool IsGateOpened=false;

    void Update()
    {
        if(IsGateOpened){
            OpenGates();
        }
        
    }

    public void OpenGates()
    {
        autoGate1.transform.DORotate(new Vector3(0,0,openingAngle),movementDuration).SetLink(autoGate1);
        autoGate2.transform.DORotate(new Vector3(0,0,-openingAngle),movementDuration).SetLink(autoGate2);
        }
}
