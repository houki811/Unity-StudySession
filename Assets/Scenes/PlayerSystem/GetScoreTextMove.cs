using UnityEngine;

public class GetScoreTextMove : MonoBehaviour
{
    private float timer = 0;
    [SerializeField] private float moveSpeed = 0.2f;
    [SerializeField] private float summonTime = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.unscaledDeltaTime;
        if (timer > summonTime)
            Destroy(this.gameObject);
        else
            transform.position += new Vector3(0, moveSpeed * Time.deltaTime, 0);
    }
}
