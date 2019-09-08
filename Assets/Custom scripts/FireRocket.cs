using UnityEngine;

public class FireRocket : MonoBehaviour
{

    public Rigidbody rocket;
    public float speed = 400f;
    public float fireRateRocket = 0.8f;

    private Rigidbody instance;
    private Vector3 pos;
    private Vector3 aimingDirection;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 40); // opt -> z-os
        Debug.Log("-------------------------------.");
        Debug.Log(pos);

        pos = Camera.main.ScreenToWorldPoint(pos);
        Debug.Log(pos);
        Debug.Log("------------------------------.");


        aimingDirection = pos - transform.position;
        transform.rotation = Quaternion.LookRotation(aimingDirection);
        

        if (Input.GetMouseButtonDown(1) && timer >= fireRateRocket) {
            timer = 0;
            instance = Rigidbody.Instantiate(rocket, transform.position, transform.rotation);
            instance.velocity = transform.forward * speed;
        }
    }

}
