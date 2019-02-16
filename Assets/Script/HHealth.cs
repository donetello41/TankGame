using UnityEngine;
using UnityEngine.UI;


public abstract class HHealth : MonoBehaviour {

    float health = 100f;
    public Text healtText;

    public void takeDamage()
    {
        health = health - (health * 0.2f);
        healtText.text = health.ToString();
        if(health <= 1)
        {
            healtText.text = "0";
            Die();
        }
    }
    public abstract void Die();
}
