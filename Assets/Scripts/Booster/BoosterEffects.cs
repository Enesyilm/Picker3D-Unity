using UnityEngine;

public class BoosterEffects : MonoBehaviour
{
    [SerializeField] float boostDuration=1;
   private void OnTriggerEnter(Collider other) {
       GameState.PlayerHaveBoost=true;
       GameState.CurrentBoostDuration=boostDuration;
       Destroy(gameObject);
   }
}
