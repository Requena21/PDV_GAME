using UnityEngine;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour
{
    public float health = 50;
    void Update()
    {
        if (GameObject.FindWithTag("Enemy") == null)
        {
            SceneManager.LoadScene("Level2");
        }
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

}
