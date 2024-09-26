using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Entered with: " + other.name);
        if (other.CompareTag("Enemy"))
        {
            EnemyController enemyController = other.GetComponent<EnemyController>();
            if (enemyController != null)
            {
                enemyController.GotHit();
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
