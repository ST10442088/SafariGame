using System.Collections;
using UnityEngine;

public class PickupSystem : MonoBehaviour
{

    int waitForSeconds = 3;
    int scoreIncrement = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.SetActive(false);
        Score.currentInstance.AddScore(scoreIncrement);

      Invoke("BoxReAppearance", waitForSeconds);
    }


 

    private void BoxReAppearance()
    {
        this.gameObject.SetActive(true);
    
    }
}
