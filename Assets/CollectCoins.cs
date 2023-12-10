using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    [SerializeField]
    private int coins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("HELLO");
        if (other.gameObject.CompareTag("Coin"))
        {
            coins++;
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
        }
    }
}
