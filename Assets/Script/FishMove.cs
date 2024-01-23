using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(NavMeshAgent))]
public class FishMove : MonoBehaviour
{
    private Transform target;
    private NavMeshAgent agent;
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Rod").transform; //�ǂ�������Ώۂ̃I�u�W�F�N�g��transform���擾
        rigidbody = GetComponent<Rigidbody>(); //Rigidbody���擾
        rigidbody.constraints = RigidbodyConstraints.FreezeRotation; //�I�u�W�F�N�g�̉�]��h��
        agent = GetComponent<NavMeshAgent>(); //NavMeshAgent���擾
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }
}
