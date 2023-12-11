using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenuManager : MonoBehaviour
{
    public Transform head;
    public float spawnDistance = 2;
    public GameObject Pmenu;
    public InputActionProperty showButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(showButton.action.WasPressedThisFrame())
        {
            Pmenu.SetActive(!Pmenu.activeSelf);

            Pmenu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        }
        Pmenu.transform.LookAt(new Vector3(head.position.x, Pmenu.transform.position.y, head.position.z));
        Pmenu.transform.forward *= -1;
    }
}
