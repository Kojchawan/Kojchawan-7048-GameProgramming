using TMPro;
using UnityEngine;

public class LiveDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    public void UpdateLivesScore(int Lives)
    {
        scoreText.text = $"Lives: {Lives}";
    }
}
