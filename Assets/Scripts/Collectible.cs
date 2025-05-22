using UnityEngine;

public class Collectible : MonoBehaviour
{

    [SerializeField] float rotationSpeed;
    [SerializeField] GameObject onCollectEffect;
    void Start()
    {

    }


    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Destroy the collectible
            Destroy(gameObject);

            //Instantiate the particle effect
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }        

        
    }
}
