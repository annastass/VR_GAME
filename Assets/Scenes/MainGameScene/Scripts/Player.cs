using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player MainPlayer;
    public TransitionObj obj;

    public int coins = 0;
    public Text coinsText;

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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coins++;
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            coinsText.text = coins.ToString();
        }
    }
}
