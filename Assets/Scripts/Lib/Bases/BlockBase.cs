using Lib.Interfaces;
using UnityEngine;

namespace Lib.Bases
{
    public class BlockBase : ISpellBase
    {
        public GameObject Create(Transform playerTransform)
        {
            var obj = Resources.Load("Prefabs/Block");
            var gObj = Object.Instantiate(
                    obj, 
                    playerTransform.position + new Vector3(1, 0, 0), 
                    playerTransform.rotation) 
                as GameObject;
            Object.Destroy(gObj, 0.3f);
            return gObj;
        }
    }
}