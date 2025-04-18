using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targeter : MonoBehaviour
{
    [SerializeField] private List<Target> targets = new List<Target>();

    public Target CurrentTarget { get; private set; }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.TryGetComponent<Target>(out Target target)) 
        { return; }

        targets.Add(target);

    }

    private void OnTriggerExit(Collider other)
    {
        if(!other.TryGetComponent<Target>(out Target target))
        { return; }
        
        targets.Remove(target);
        
    }

    public bool SelectTatget()
    {
        if (targets.Count == 0) 
        { return false; }

        CurrentTarget = targets[0];
        return true;
    }

    public void Cancel()
    {
        CurrentTarget = null;
    }

}