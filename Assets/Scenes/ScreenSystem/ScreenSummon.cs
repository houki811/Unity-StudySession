using UnityEngine;
using TMPro;

public class ScreenSummon : MonoBehaviour
{
    [SerializeField] private GameObject PlayerObject;
    [SerializeField] private GameObject BallSystem;
    [SerializeField] private GameObject ObstaclesSystem;

    private TextMeshProUGUI scoreText;
    public int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject Search = GameObject.Find("ScoreText");
        if (Search != null)
            scoreText = Search.GetComponent<TextMeshProUGUI>();
        Instantiate(PlayerObject,new Vector3(0,-3.74f,0),Quaternion.identity);
        Instantiate(BallSystem);
        Instantiate(ObstaclesSystem);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: "+score;
    }
}
