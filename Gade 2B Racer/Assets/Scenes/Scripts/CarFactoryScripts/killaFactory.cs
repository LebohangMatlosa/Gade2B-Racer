using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killaFactory : CarFactory
{

    [SerializeField] private killa killahPrefab;

    public override ICar createCar()
    {
        GameObject killaInstance = Instantiate(killahPrefab.gameObject);
        killa Killa = killaInstance.GetComponent<killa>();
        Killa.initialize();
        return Killa;
    }

}
