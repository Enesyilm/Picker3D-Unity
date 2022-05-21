using UnityEngine;
using DG.Tweening;

public class ElevatePlatfromOnContinue : MonoBehaviour
{
    
    
    private void Start() {
        //  DOTween.Init(true, true, LogBehaviour.Verbose).SetCapacity(3150,50);
    }
    public void ElevatePlatform()
    {
        transform.DOLocalMoveY(-2.33f,1f).SetLink(gameObject);
        // Vector3 ElevatedLoc=new Vector3(transform.position.x,-2.33f,transform.position.z);
        // transform.position=Vector3.Lerp(transform.position,ElevatedLoc,0.1f);
        // transform.Translate(new Vector3(0,-2.33f,0),Space.World);
        
    }
   
}
