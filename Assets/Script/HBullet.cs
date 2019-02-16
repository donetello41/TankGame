using UnityEngine;

public class HBullet : MonoBehaviour {
    HHealth health;
    private void OnCollisionEnter(Collision collision)
    {

        health = collision.gameObject.GetComponent<HHealth>();

        if (health != null)
        {
            health.takeDamage();
        }
        Destroy(this.gameObject);
    }


}
