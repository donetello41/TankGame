using UnityEngine;

public class HShoot : MonoBehaviour {
    new static AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    public void Shoot(Transform barrel,GameObject bullet)
    {
        GameObject go = Instantiate(bullet, barrel.position, Quaternion.identity);
        go.GetComponent<Rigidbody>().AddForce(barrel.forward * 10000);

        if (audio != null)
        {
            audio.Play();
        }
     
    }
}
