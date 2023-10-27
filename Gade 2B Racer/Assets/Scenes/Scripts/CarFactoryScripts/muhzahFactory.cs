using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muhzahFactory : CarFactory
{

    [SerializeField] private muhzah muhzahPrefab;

    public override ICar createCar()
    {
        GameObject muhzahInstance = Instantiate(muhzahPrefab.gameObject);
        muhzah Muhzah = muhzahInstance.GetComponent<muhzah>();
        Muhzah.initialize();
        return Muhzah;
    }

}
