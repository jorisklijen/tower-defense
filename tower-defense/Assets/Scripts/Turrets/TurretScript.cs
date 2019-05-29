using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class TurretScript : MonoBehaviour
{
    private Transform target;
    [Header("Unity setup fields")]

    public string enemyTag = "Enemy";
    public Transform partToRotate;

    public GameObject bulletPrefab;
    public Transform firePoint;
    public GameObject muzzleFlash;

    public AudioSource GunAudioSource;

    [Space]
    [Header("Atributes")]

    public float fireRate = 1f;
    private float fireContDown = 0f;
    public float range = 15f;
    public float rotateSpeed = 10f;
    [SerializeField] public static int turretDamage = 1; // ik heb static weg gehaald

    [Space]
    [Header("Upgrades")]
    public Text upgradeCostsText;
    public Text noMoney;
    public float upgradeCosts;
    public GameObject nextTierTurret;
    public string notUpgradeMessage;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
        turretDamage = turretDamage * 10;
    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            return;
        }

        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * rotateSpeed).eulerAngles;
        partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);

        if (fireContDown <= 0)
        {
            Shoot();
            fireContDown = 1f / fireRate;
        }

        fireContDown -= Time.deltaTime;

    }

    void Shoot()
    {
        Debug.Log("Shoot!");
        GameObject bulletGo = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        BulletScript bullet = bulletGo.GetComponent<BulletScript>();
        if (bullet != null)
        {
            bullet.Seek(target);
        }
        GameObject MuzzleFlash = (GameObject)Instantiate(muzzleFlash, firePoint.position, firePoint.rotation);
        Destroy(MuzzleFlash, .1f);
        GunAudioSource.Play();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }

    private void OnMouseEnter()
    {
        upgradeCostsText.text = "Upgrade Costs: €" + upgradeCosts;
    }

    private void OnMouseExit()
    {
        upgradeCostsText.text = "";
    }



    private void OnMouseDown()
    {
        BuildManager b = new BuildManager();
        if (b.money >= 0)
        {
            Instantiate(nextTierTurret, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        else
        {
            noMoney.text = notUpgradeMessage;
        }
    }
}
