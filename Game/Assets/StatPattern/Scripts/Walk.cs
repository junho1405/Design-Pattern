using UnityEngine;

public class Walk : MonoBehaviour
{
    public override void Enter(Character character) 
    {
        
    }
    public override void Update(Character character)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {

        }
        if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 0 )
        {

        }

        int x = (int)Input.GetAxisRaw("Horizontal");

        character.animator.SetInteger("X", x);


    }
    public override void Exit(Character character);
}
