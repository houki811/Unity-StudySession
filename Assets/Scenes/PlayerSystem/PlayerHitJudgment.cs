using UnityEngine;

public class PlayerHitJudgment : MonoBehaviour
{
    [SerializeField] private GameObject EndScreen;
    [SerializeField] private GameObject PlayerObject;
    [SerializeField] private GameObject PlayerObjectGameOver;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Obstacles"))
        {
            Instantiate(PlayerObjectGameOver,new Vector3(collision.transform.position.x,-3.86f,0),Quaternion.identity);
            Destroy(PlayerObject);
            Instantiate(EndScreen, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
