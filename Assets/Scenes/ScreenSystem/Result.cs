using UnityEngine;
using TMPro;

public class Result : MonoBehaviour
{
    [SerializeField] private GameObject GameOverUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject resultUI = Instantiate(GameOverUI, new Vector3(0, 0, 0), Quaternion.identity);
        Transform canvasObject = resultUI.transform.Find("FinalScore");
        GameObject scoreText = GameObject.Find("ScreenSystem");
        if (canvasObject != null&&scoreText!=null)
        {
            TextMeshProUGUI canvasText = canvasObject.GetComponent<TextMeshProUGUI>();
            ScreenSummon script = scoreText.GetComponent<ScreenSummon>();
            canvasText.text = "FINALSCORE:\n" + script.score;
        }
        Time.timeScale = 0;
        GameObject canvasSearch = GameObject.Find("Canvas");
        canvasSearch.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
