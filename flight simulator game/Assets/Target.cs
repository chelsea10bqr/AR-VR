using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 5.0f;

    public void TakeDamage(float amount)
    {
        Score.scoreValue += 1;
        health -= amount;
        if(health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
