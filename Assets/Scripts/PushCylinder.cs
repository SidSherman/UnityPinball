
using UnityEngine;

public class PushCylinder : MonoBehaviour
{
    [SerializeField] private float _power;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Rigidbody body))
        {
            Vector3 direction = collision.gameObject.transform.position - transform.position;
            body.AddForce(direction.normalized * _power , ForceMode.Impulse);
        }
    }
}
