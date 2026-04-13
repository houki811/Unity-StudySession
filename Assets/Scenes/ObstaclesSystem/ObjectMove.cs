using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    [SerializeField] private GameObject objectPrefab;
    [SerializeField] private float speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        if (transform.position.y <= -4.5f)
            Destroy(this.gameObject);
    }
}
