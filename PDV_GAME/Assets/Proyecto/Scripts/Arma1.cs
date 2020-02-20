using UnityEngine;

public class Arma1 : MonoBehaviour
{
    public float impactForce = 30.0f;
    public float damage = 10.0f;
    public float range = 100.0f;
    public Camera fpsCam;
    public ParticleSystem muzzleFlare;
    public GameObject impactEffect;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }


    }

    void shoot()
    {
        muzzleFlare.Play();
        RaycastHit hitInfo;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hitInfo, range))
        {
            Debug.Log(hitInfo.transform.name);
            Target target = hitInfo.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
            if (hitInfo.rigidbody != null)
            {
                hitInfo.rigidbody.AddForce(-hitInfo.normal * impactForce);
            }
            Instantiate(impactEffect, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
        }


    }
}
