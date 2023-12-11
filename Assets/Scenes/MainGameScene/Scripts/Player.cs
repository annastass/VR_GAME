using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static Player MainPlayer;
    public TransitionObj obj;

    private void Awake()
    {
        MainPlayer = this;
    }

    public void Return()
    {
        StartCoroutine(ReturnWait());
    }

    public IEnumerator ReturnWait()
    {
        obj.PlayHide();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}
