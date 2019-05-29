using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    public GameObject gunTurret;
    public GameObject rocketTurret;
    public GameObject lazerTurret;
    public GameObject geldTurret;
    public GameObject superTurret;
    [Space]
    public float gunPrice;
    public float rocketPrice;
    public float lazerPrice;
    public float geldPrice;
    public float superPrice;
    [Space]
    public Text moneyText;
    public float money;
    public Text errorText;
    [Space]
    public bool isInShop;

    public GameObject shopPanel;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("More than one Buildmanager in scene!");
            return;
        }
        instance = this;
    }

    public GameObject standardPrefab;

    private void Start()
    {
        turretToBuild = standardPrefab;
    }

    private void Update()
    {
        moneyText.text = "€" + money.ToString();


        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            turretToBuild = null;
        }
    }

    private GameObject turretToBuild;

    public GameObject GetBuildTurretToBuild()
    {
        return turretToBuild;
    }

    public void SelectGun()
    {
        if (money - gunPrice >= 0)
        {
            turretToBuild = gunTurret;
            money = money - gunPrice;
        }
        else StartCoroutine(NoMoney());
    }
    public void SelectRocket()
    {
        if (money - rocketPrice >= 0)
        {
            turretToBuild = rocketTurret;
            money = money - rocketPrice;
        }
        else StartCoroutine(NoMoney());
    }
    public void SelectLazer()
    {
        if (money - lazerPrice >= 0)
        {
            turretToBuild = lazerTurret;
            money = money - lazerPrice;
        }
        else StartCoroutine(NoMoney());
    }
    public void SelectGeld()
    {
        if (money - geldPrice >= 0)
        {
            turretToBuild = geldTurret;
            money = money - lazerPrice;
        }
        else StartCoroutine(NoMoney());
    }
    public void SelectSuper()
    {
        if (money - superPrice >= 0)
        {
            turretToBuild = superTurret;
            money = money - superPrice;
        }
        else StartCoroutine(NoMoney());
    }

    public void Shop()
    {
        isInShop = !isInShop;

        if(isInShop == true)
        {
            shopPanel.SetActive(true);
        }
        if (isInShop == false)
        {
            shopPanel.SetActive(false);
        }
    }

    IEnumerator NoMoney()
    {
        errorText.text = "Sorry, Not enough money";
        yield return new WaitForSeconds(2);
        errorText.text = "";
    }
}
