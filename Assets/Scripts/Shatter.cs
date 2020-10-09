using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shatter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            #region smoke effect
            //MAKE ONE MORE ENEMY OBJECT POOLING
            //Name: SoulEffect
            //Pool Amount: 2
            //Pool Obect: [prefab]
            //Should Expand: checked

            //GameObject smokeEffect = ObjectPooling.instance.GetPooledObject("SoulEffect");
            //soulEffect.transform.position = transform.position;
            //soulEffect.SetActive(true);
            //soulEffect.GetComponent<Animator>().Play("SoulEffect", -1, 0);

            //don't forget to turn off LOOP for soul effect
            #endregion

            //ScoreSystem.instance.IncreaseSouls();

            //this puts a message in the Console that the impact has hit, i took it off because idc
            //Debug.Log("Collided with Ground");
            //This is script that makes the object disappear when hitting the ground!
            gameObject.SetActive(false);
        }


        //BELOW IS WHEN SOULS TOUCH GROUND, I NEED TO FIGURE OUT WHAT THE SCRIPT IS TO TRIGGER GAME OVER WHEN 3 OF THEM TOUCH THE GROUND
        //NEED TO ADD GAME OVER SCRIPT


        if (other.CompareTag("ground"))
        {
            #region smoke effect
            //MAKE ONE MORE ENEMY OBJECT POOLING
            //Name: SoulEffect
            //Pool Amount: 2
            //Pool Obect: [prefab]
            //Should Expand: checked

            //GameObject smokeEffect = ObjectPooling.instance.GetPooledObject("SoulEffect");
            //soulEffect.transform.position = transform.position;
            //soulEffect.SetActive(true);
            //soulEffect.GetComponent<Animator>().Play("SoulEffect", -1, 0);

            //don't forget to turn off LOOP for soul effect
            #endregion

            //this puts a message in the Console that the impact has hit, i took it off because idc
            //Debug.Log("Collided with ground");
            //This is script that makes the object disappear when hitting the ground!
            gameObject.SetActive(false);

           //Health.health -= 1;
        }
    }
}
