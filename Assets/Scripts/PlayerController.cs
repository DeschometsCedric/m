using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Coffre coffre;
    public bool menuOuvert;
    public bool coffreOuvert;

    void Start()
    {
        Item item = coffre.GetComponent<Inventaire>().slots[0].item;
        Item itemPris = coffre.GetComponent<Inventaire>().PrendreItem(item);
        GetComponent<Inventaire>().DeposerItem(itemPris);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            GetComponent<Inventaire>().inventaireUI.gameObject.SetActive(coffreOuvert);
            coffre.GetComponent<Inventaire>().inventaireUI.gameObject.SetActive(coffreOuvert);
            GetComponent<Stuff>().inventaireUI.gameObject.SetActive(false);
            coffreOuvert = !coffreOuvert;
            menuOuvert = false;
        }

        if (Input.GetKeyUp(KeyCode.I))
        {
            GetComponent<Inventaire>().inventaireUI.gameObject.SetActive(menuOuvert);
            GetComponent<Stuff>().inventaireUI.gameObject.SetActive(menuOuvert);
            coffre.GetComponent<Inventaire>().inventaireUI.gameObject.SetActive(false);
            menuOuvert = !menuOuvert;
            coffreOuvert = false;
        }
    }
}
