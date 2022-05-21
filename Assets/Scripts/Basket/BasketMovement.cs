using UnityEngine;

public class BasketMovement : MonoBehaviour
{
    bool left;
    bool right;
    public static float swerveSensitivity=5;
    
    [SerializeField]float planeSize=0.8f;
   
    void FixedUpdate()
    {
       
        
        if(Input.touchCount>0)
        {
            Touch touchInput = Input.GetTouch(0);
            DecideLeftOrRight(touchInput);
            ApplyForce();

        }

    }

    private void DecideLeftOrRight(Touch touchInput)
    {
        if (touchInput.deltaPosition.x > swerveSensitivity)
        {
            right = true;
            left = false;

        }
        if (touchInput.deltaPosition.x < -swerveSensitivity)
        {
            right = false;
            left = true;

        }
    }

    private void ApplyForce()
    {
        if (left)
        {
            float posx = Mathf.Lerp(transform.position.x, -planeSize, Time.deltaTime * 1f);
            transform.position = new Vector3(posx, transform.position.y, transform.position.z);
        }
        if (right)
        {

            float posx = Mathf.Lerp(transform.position.x, planeSize, Time.deltaTime * 1f);
            transform.position = new Vector3(posx, transform.position.y, transform.position.z);

        }
    }
}
