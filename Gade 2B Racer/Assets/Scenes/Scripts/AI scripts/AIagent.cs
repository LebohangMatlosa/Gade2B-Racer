using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIagent : MonoBehaviour
{
    [SerializeField] private Transform MovePos;
    private NavMeshAgent kILLA;

    private void Awake()
    {
        kILLA = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        kILLA.destination = MovePos.position;
    }
}
