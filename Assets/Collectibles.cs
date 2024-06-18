using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool isCoins, isSpeedUp;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            if (isCoins)
            {
                Test1 playerScript = other.GetComponent<Test1>();
                playerScript.score++;
                Destroy(gameObject);
            }
            if (isSpeedUp)
            {
                playerScript.moveSpeed *= 1.2f;
                Destroy(gameObject);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
