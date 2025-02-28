using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float MoveSpeed;

    [SerializeField]
    private GameObject arrow;

    [SerializeField]
    private Transform shooting;

    [SerializeField]
    private float shootInterval = 0.05f;

    private float lastShootTime = 0f;


    void Update()
    {
        float leftrightInput = Input.GetAxisRaw("Horizontal");
        float updownInput = Input.GetAxisRaw("Vertical");
        Vector3 moving = new Vector3(leftrightInput, updownInput, 0f);
        transform.position += MoveSpeed * Time.deltaTime * moving;

        shoot();
    }
    void shoot()
    {
        if (Time.time - lastShootTime > shootInterval)
        {
            Instantiate(arrow, shooting.position, Quaternion.identity);
            lastShootTime = Time.time;
        }
    }
        
}
