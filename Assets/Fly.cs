using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    [SerializeField]
    float eulerAngX;
    [SerializeField]
    float eulerAngY;
    [SerializeField]
    float eulerAngZ;


    private bool turnLeft;
    private bool turnRight;
    private bool dive;
    private bool climb;

    public float speed = 0.5f;
    public float turnSpeed = 0.4f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // ForwardMovement();
        GetAngles();
        Stabilize();
        ForwardMovement();
    }

    private void ForwardMovement()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
    }

    private void GetAngles()
    {
        eulerAngX = transform.localEulerAngles.x;
        eulerAngY = transform.localEulerAngles.y;
        eulerAngZ = transform.localEulerAngles.z;
    }

    private void Stabilize()
    {
        if (eulerAngZ < 270f && eulerAngZ > 268f)
        {
            eulerAngX = eulerAngX + 0.2f;
            eulerAngZ = 270f;
            transform.eulerAngles = new Vector3(eulerAngX, eulerAngY, eulerAngZ);
        }

        if (eulerAngZ > 90f && eulerAngZ < 92f)
        {
            eulerAngX = eulerAngX + 0.2f;
            eulerAngZ = 90f;
            transform.eulerAngles = new Vector3(eulerAngX, eulerAngY, eulerAngZ);
        }
    }
        
    
}
