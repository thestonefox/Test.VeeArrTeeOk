namespace TheStonefox.Test.VeeArrTeeOk.Prefabs.Debugz
{
    using UnityEngine;

    public class Debuginator : MonoBehaviour
    {
        VeeTeeKator v = new VeeTeeKator();
        Rebuggler r = new Rebuggler();

        protected virtual void OnEnable()
        {
            Debug.Log(v.VeeTeeKate() + r.Rebugglate());
        }
    }
}