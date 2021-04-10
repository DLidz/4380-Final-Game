using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerZS : MonoBehaviour
{
    private float moveSpeed = 6;
    [SerializeField] GameObject playerBullet;
    [SerializeField] float projectileSpeed = 50f;

    Coroutine firingCoroutine;

    public GameObject wayPoint;
    

    private float timer = 0.5f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Fire();

        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
           
            UpdatePosition();
            timer = 0.5f;
        }
    }

    void UpdatePosition()
    {
        
        wayPoint.transform.position = transform.position;
    }


    private void Move()
    {
        float deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float newXPos = Mathf.Clamp(transform.position.x + deltaX, -7.7f, 8.5f);

        float deltaY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float newYPos = Mathf.Clamp(transform.position.y + deltaY, -4.3f, 3.8f);
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
        transform.position = new Vector2(newXPos, newYPos);
    }


    private void Fire()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 direction = (Vector2)((worldMousePos - transform.position));
            direction.Normalize();

            GameObject laser = Instantiate(playerBullet, transform.position + (Vector3)(direction * 0.5f), Quaternion.identity);
            laser.GetComponent<Rigidbody2D>().velocity = direction * projectileSpeed;
          
        }

    }

}
