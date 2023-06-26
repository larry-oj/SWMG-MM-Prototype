using Lib.Interfaces;
using UnityEngine;

namespace Lib.Bases
{
    public class ProjectileBase : ISpellBase
    {
        public GameObject Create(Transform playerTransform)
        {
            var obj = Resources.Load("Prefabs/Projectile");
            return Object.Instantiate(
                obj, 
                playerTransform.position + new Vector3(1, 0, 0), 
                playerTransform.rotation) 
                as GameObject;
        }
    }
}