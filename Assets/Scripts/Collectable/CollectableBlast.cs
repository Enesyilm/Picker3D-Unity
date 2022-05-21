using UnityEngine;

public class CollectableBlast : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Collector"))
        {
            for (int index = 0; index < 2; index++)
            {
                Invoke("BlastItem",2.5f);
                
            }
        }
    }

    private void BlastItem()
    {
        GameObject blastParticle;
        gameObject.SetActive(false);
        blastParticle = CreateObject();
        DynamicProperties(blastParticle);
        Destroy(blastParticle, 1f);
    }

    private void DynamicProperties(GameObject blastParticle)
    {
        Rigidbody rb = blastParticle.AddComponent<Rigidbody>();
        rb.AddForce(0, 1, 0);
        rb.mass = .1f;
        rb.AddExplosionForce(10, transform.position, 30, 30);
        rb.useGravity = true;
    }

    private GameObject CreateObject()
    {
        GameObject blastParticle = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        blastParticle.transform.position = transform.position;
        var sr =blastParticle.GetComponent<Renderer>();
        sr.material.color=Color.white;
        blastParticle.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
        return blastParticle;
    }
}
