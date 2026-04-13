using UnityEngine;
using TMPro;

public class BasketJudgement : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Text;
    private Transform CanvasTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject canvasSearch = GameObject.Find("CalculationCanvas");
        if(canvasSearch != null)
            CanvasTransform = canvasSearch.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            GameObject scoreText = GameObject.Find("ScreenSystem");
            if (scoreText != null)
            {
                ScreenSummon script = scoreText.GetComponent<ScreenSummon>();
                TextMeshProUGUI getScoreText = Instantiate(Text, CanvasTransform);
                getScoreText.transform.position = new Vector3(collision.transform.position.x + 0.8f, -2.2f, 0);
                script.score += 100;
            }
            Destroy(collision.gameObject);
        }
    }
}
