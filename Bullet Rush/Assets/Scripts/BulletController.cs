using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 movement;
    public void Fire(Vector3 direction)
    {
        movement = direction * speed * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        transform.position += movement;
    }
}
