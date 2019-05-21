using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Transform target;

    public float speed = 100f;

    public GameObject impactEffect;

    public void Seek(Transform _target)
    {
        target = _target;
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if(dir.magnitude <= distanceThisFrame)
        {
            HitTarget(target);
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        transform.LookAt(target);
    }

    void HitTarget(Transform enemy)
    {
        GameObject EffectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(EffectIns, 1f);

        EnemyBehavourScript e = enemy.GetComponent<EnemyBehavourScript>();
        if(e != null)
        {
            e.GetShot(TurretScript.turretDamage);
        }

    }
}
