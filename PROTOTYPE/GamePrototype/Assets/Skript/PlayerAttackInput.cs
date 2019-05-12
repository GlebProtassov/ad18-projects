using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackInput : MonoBehaviour
{
    private CharacterAnimations playerAnimation;

    // Start is called before the first frame update
    void Awake()
    {
        playerAnimation = GetComponent<CharacterAnimations>();

    }

    // Update is called once per frame
    void Update(){
        if (Input.GetMouseButtonDown(2))
        {
            playerAnimation.Defend(true);
        }
        if(Input.GetMouseButtonUp(2))
        {
            playerAnimation.UnFreezeAnimation();
            playerAnimation.Defend(false);
        }
        if (Input.GetMouseButtonDown(0))
        {
            if(Random.Range(0,2)>0){
                playerAnimation.Attack_1();
            }else{
                playerAnimation.Attack_2();
            }
        }
    }
}