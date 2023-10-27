using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CarFactory : MonoBehaviour
{
    public abstract ICar createCar();
}

