using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class Fly : MonoBehaviour
{

        [SerializeField]
        public float speed = 2.0f;
        private Rigidbody rb;
        public int coins = 0;
        public Text cointText;
        private TrackedPoseDriver headPose;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
            headPose = Camera.main.GetComponent<TrackedPoseDriver>();
         
        }

        private void Update()
        {
            Vector3 headForward = headPose.transform.forward;
            Vector3 headRight = headPose.transform.right;

            float moveHorizontal = Input.GetAxis("Horizontal"); // Допустим, управление происходит с использованием клавиш клавиатуры или контроллера
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 moveDirection = headForward * moveVertical + headRight * moveHorizontal;
            rb.velocity = moveDirection * speed;
            cointText.text = coins.ToString();
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
   /* [SerializeField]
    float eulerAngX;
    [SerializeField]
    float eulerAngY;
    [SerializeField]
    float eulerAngZ;
    [SerializeField]
    private int coins;


    private bool turnLeft;
    private bool turnRight;
    private bool dive;
    private bool climb;

    public float speed = 0.1f;
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
        //OnTriggerEnter();
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

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            coins++;
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
        }
    }

    private void Turn()
    {
        if(turnLeft)
        {
            eulerAngZ = eulerAngZ + turnSpeed;
            transform.eulerAngles = new Vector3(eulerAngX, eulerAngY, eulerAngZ);
        }

        if (turnRight)
        {
            eulerAngZ = eulerAngZ - turnSpeed;
            transform.eulerAngles = new Vector3(eulerAngX, eulerAngY, eulerAngZ);
        }

        if (dive)
        {
            eulerAngX = eulerAngX + turnSpeed;
            transform.eulerAngles = new Vector3(eulerAngX, eulerAngY, eulerAngZ);
        }
        if (climb)
        {
            bool sharpTurnNoLiftLeft = eulerAngZ < 92 && eulerAngZ > 69;
            bool sharpTurnLittleLiftLeft = eulerAngZ < 69 && eulerAngZ > 49;
            bool mildTurnAndLiftLeft = eulerAngZ < 49 && eulerAngZ > 29;
            bool sharpTurnNoLiftRight = eulerAngZ < 269 && eulerAngZ > 292;
            bool sharpTurnLittleLiftRight = eulerAngZ < 292 && eulerAngZ > 312;
            bool mildTurnAndLiftRight = eulerAngZ < 312 && eulerAngZ > 332;


            if (sharpTurnNoLiftLeft)
            {
                eulerAngY -= turnSpeed * Time.deltaTime * 100f;

            }

             else if (sharpTurnLittleLiftLeft)
            {
                eulerAngY -= turnSpeed * Time.deltaTime * 85f;
                eulerAngX -= turnSpeed * Time.deltaTime * 20f;

            }
             else if (mildTurnAndLiftLeft)
            {
                eulerAngY -= turnSpeed * Time.deltaTime * 40f;
                eulerAngX -= turnSpeed * Time.deltaTime * 60f;

            }
            else if (sharpTurnNoLiftRight)
            {
                eulerAngY += turnSpeed * Time.deltaTime * 100f;

            }
            else if (sharpTurnLittleLiftRight)
            {
                eulerAngY += turnSpeed * Time.deltaTime * 85f;
                eulerAngX -= turnSpeed * Time.deltaTime * 20f;


            }
            else if (mildTurnAndLiftRight)
            {

                eulerAngY += turnSpeed * Time.deltaTime * 40f;
                eulerAngX -= turnSpeed * Time.deltaTime * 60f;

            }
            else
            {
                eulerAngX -= turnSpeed;
            }

            transform.eulerAngles = new Vector3(eulerAngX, eulerAngY, eulerAngZ);

        }
    }

    private void GetTurn()
    {
        Vector3 flyDirection = 
        if (OVRInput.GetDown())
    }//

}*/
