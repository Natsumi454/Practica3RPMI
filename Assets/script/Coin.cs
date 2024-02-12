using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioClip coinClip;
    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<MarioMovement>())
        {
            GameManager.instance.SetScore(GameManager.instance.GetScore() + 50);
            Destroy(gameObject);

            List<GameObject> ListCoins = new List<GameObject>();
            ListCoins.Add(gameObject);
            foreach (GameObject gameObject in ListCoins)
            {
                Debug.Log(gameObject);
            }

            AudioManager.instance.PlayAudio(coinClip, "coinClip");
        }
    }
}
