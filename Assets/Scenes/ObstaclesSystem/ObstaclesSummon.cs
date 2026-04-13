using UnityEngine;

public class ObstaclesSummon : MonoBehaviour
{
    [SerializeField] private GameObject BomdAppearance;
    private float timer = 0;
    [SerializeField] private float lowestInterval = 1.0f;
    [SerializeField] private float probability = 3.3f; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > lowestInterval && probability > Random.Range(0.0f,10.0f))
        {
            summon();
        }
        else if(timer>lowestInterval/2 && probability > Random.Range(0.0f, 15.0f))
        {
            summon();
        }
    }
    void summon()
    {
        float summonLocation = Random.Range(-8.5f, 8.5f);
        Instantiate(BomdAppearance, new Vector3(summonLocation, 6, 0), Quaternion.identity);
        timer = 0;
    }
}
