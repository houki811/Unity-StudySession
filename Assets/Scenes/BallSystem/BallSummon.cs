using UnityEngine;

public class BallSummon : MonoBehaviour
{
    [SerializeField] private GameObject BallAppearance;
    private float timer = 0;
    [SerializeField] private float interval=1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > interval)
        {
            float summonLocation = Random.Range(-8.5f, 8.5f);
            Instantiate(BallAppearance, new Vector3(summonLocation, 6, 0), Quaternion.identity);
            timer = 0;
        }

    }
}
