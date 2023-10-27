using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CarSpawner : CarFactory
{
    [SerializeField] private CarSpawner[] carFactories;

    private void Start()
    {
        ICar tonka = carFactories[0].createCar();
        tonka.initialize();

        ICar muhzah = carFactories[1].createCar();
        muhzah.initialize();

        ICar killa = carFactories[2].createCar();
        killa.initialize();

    }
}