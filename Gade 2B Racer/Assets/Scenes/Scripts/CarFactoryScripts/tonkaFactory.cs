using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tonkaFactory : CarFactory
{
    [SerializeField] private tonka tonkaPrefab;

    public override ICar createCar()
    {
        GameObject tonkaInstance = Instantiate(tonkaPrefab.gameObject);
        tonka Tonka = tonkaInstance.GetComponent<tonka>();
        Tonka.initialize();
        return Tonka;
    }
}
