using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 30f;
    public float coldown;
    float lastshot=-1.5f;
    // Update is called once per frame

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            Shoot();
            Debug.Log("yes");
        }
    }

    void Shoot()
    {

        if (Time.time - lastshot < coldown)
        {
            return;
        }
        lastshot = Time.time;           
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
    }
}
