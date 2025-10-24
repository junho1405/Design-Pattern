using System.Collections.Generic;
using UnityEngine;

public class WeponManager : MonoBehaviour
{
    [SerializeField] int count;
    [SerializeField] List<Wepon> Wepons;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Swap();
        }
    }

    void Attack()
    {
        if (Wepons.Count == 0) return;
        Wepons[count].Launch();
    }

    void Swap()
    {
        if (Wepons.Count == 0) return;

        Wepons[count].gameObject.SetActive(false);
        count = (count + 1) % Wepons.Count;
        Wepons[count].gameObject.SetActive(true);
    }
}
