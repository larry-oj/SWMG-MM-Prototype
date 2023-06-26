using Lib.Interfaces;
using UnityEngine;

namespace Lib.Effects
{
    public class EarthEffect : ISpellEffect
    {
        public void ApplyEffect(GameObject obj)
        {
            obj.GetComponent<SpriteRenderer>().color = Color.green;
        }
    }
}