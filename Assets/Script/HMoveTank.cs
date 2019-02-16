using UnityEngine;

public class HMoveTank : MonoBehaviour {

    float turnAxis, movementAxis;
    float moveSpeed = 30, rotSpeed = 10;
    HShoot shoot;
    public Transform barrel;
    public GameObject bullet;

    // Use this for initialization
    void Start () {
        shoot = FindObjectOfType<HShoot>();
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKeyDown(KeyCode.Space))
            shoot.Shoot(barrel, bullet);
        ControllTankWithKeyboard();
    }

    private void ControllTankWithKeyboard()
    {
        movementAxis = Input.GetAxisRaw("Vertical");
        turnAxis = Input.GetAxisRaw("Horizontal");

        transform.position += transform.forward * moveSpeed * movementAxis * Time.deltaTime;
        Vector3 rotVector = new Vector3(0, 1, 0) * turnAxis * rotSpeed * Time.deltaTime * moveSpeed;
        transform.Rotate(rotVector);
    }
}
