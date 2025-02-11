using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;

    private void Update()
    {
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            score += 1;
        }
    }
}
