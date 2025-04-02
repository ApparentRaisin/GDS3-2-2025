using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//I want my player to start loosing health when they click on anything that is "poisoned"
//But at the moment they loose health but never stop
//and its also weirdly jittery and fast?
// they should only be loosing 1 health a second
public class Poision : MonoBehaviour
{
    public Player player;

    private void OnMouseOver()
    {
        // click on the object and start loosing health
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Poison());
        }
    }

    IEnumerator Poison()
    {
        
        /*do
        {
            //wait a second before loosing
            yield return new WaitForSeconds(1);
            player.health --;
            if(player.health < 0)
            {
                player.health = 0;
                Debug.Log("Negative");
                break;
                
            }
            
            //stop once they are out of health
        } while (player.health >= 0);*/
        /*for(int i = player.health; i > 0; i--)
        {
            yield return new WaitForSeconds(1);
            player.health = i;
        }*/
        while(player.health > 0)
        {
            
            yield return new WaitForSeconds(1);
            if (player.health <= 0)
            {
                break;
            }
            player.health--;
        }

        
    }
}
