using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float randomSize = Random.Range(0.5f, 1.5f);
        transform.localScale = new Vector3(randomSize, randomSize, 1);
        float randomSpeed = Random.Range(100f, 300f) / randomSize;
        rb = GetComponent<Rigidbody2D>();
        Vector2 randomDirection = Random.insideUnitCircle.normalized;
        rb.AddForce(randomDirection * randomSpeed);
        rb.AddTorque(Random.Range(-100f, 100f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
