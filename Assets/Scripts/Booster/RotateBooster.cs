using UnityEngine;

public class RotateBooster : MonoBehaviour
{
    public enum LeftOrRight{
        Left,
        Right
    }
    [SerializeField] LeftOrRight rotationWay=LeftOrRight.Left;
    [SerializeField] float rotationSpeed=4f;

    void Update()
    {
        if(rotationWay==LeftOrRight.Left){
            transform.Rotate(Vector3.up*rotationSpeed);
        }
        else{
            transform.Rotate(Vector3.down*rotationSpeed);  
        }
         
    }
}
