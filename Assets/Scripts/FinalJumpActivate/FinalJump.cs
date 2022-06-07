using UnityEngine;

public class FinalJump : MonoBehaviour
{
    [SerializeField] VerticalMovement verticalMovement;
    public static bool IsFinalJumptriggered=false;

    void Update()
    {
        if(IsFinalJumptriggered)
        {
            ChangeRigidBodyProps();
            DetectTaps();
        }
         
    }

    private void DetectTaps()
    {
        if (Input.GetMouseButtonDown(0))
        {
            verticalMovement.enabled = true;
            VerticalMovement.currentBasketState = VerticalMovement.BasketState.Moving;

        }
    }

    private void ChangeRigidBodyProps()
    {
        Rigidbody rb1 = gameObject.GetComponent<Rigidbody>();
        rb1.mass = 0.1f;
        rb1.isKinematic = false;
    }
}
