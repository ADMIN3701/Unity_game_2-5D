using UnityEngine;

public class Hero_Animation : MonoBehaviour
{
    private Animator _animator;
    // Start is called before the first frame update
    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
            _animator.SetBool("Side_Attack_1", true);
    }

    public void Animationfalse()
    {
        _animator.SetBool("Side_Attack_1", false);
    }
}
