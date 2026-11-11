using UnityEngine;

public class DestroyBall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Score.Instance.remainingBalls();
            Destroy(other.gameObject);
        }
    }
}
