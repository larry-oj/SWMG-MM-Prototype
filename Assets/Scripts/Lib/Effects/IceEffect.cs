using Lib.Interfaces;
using UnityEngine;

namespace Lib.Effects
{
    public class IceEffect : ISpellEffect
    {
        public void ApplyEffect(GameObject obj)
        {
            obj.GetComponent<SpriteRenderer>().color = Color.blue;
        }
    }
}