using AutoHitManager.Cat;
using System;
using System.Linq;
using UnityEngine;

namespace AutoHitManager.Managers
{
    public class BehaviourManager : MonoBehaviour
    {
        
        public void Update()
        {
            if (HeroController.instance?.gameObject != null)
            {
                if(!HeroController.instance.gameObject.GetComponents<CollisionManager>().Any())
                {
                    HeroController.instance.gameObject.AddComponent<CollisionManager>();
                }
            }

            if (HeroController.instance.cState.lookingUp)
            {
                BindableFunctions.FuryStep(BindableFunctions.UP);
            }
            else if (HeroController.instance.cState.lookingDown)
            {
                BindableFunctions.FuryStep(BindableFunctions.DOWN);
            }
        }
    }
}