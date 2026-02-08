using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static System.Net.Mime.MediaTypeNames;

public class Hoop : MonoBehaviour
{
    public GameObject popEffectPrefab;
    public TMP_Text scoreText;
    private int score;

    void Start()
    {
        scoreText.text = "Score: 0";
        score = 0;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (transform.parent == null && collision.gameObject.GetComponent<Hoop>() == null)
        {
            PopBalloon();
            score += 1;
            scoreText.text = "Score: " + score;
        }
    }

    private void PopBalloon()
    {
        if (popEffectPrefab != null)
        {
            GameObject effect = Instantiate(popEffectPrefab, transform.position, transform.rotation);
            Destroy(effect, 1f);
        }
    }
}
