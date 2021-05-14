using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityTemplateProjects
{
    public class StartHandler : StateHandler
    {
        public override void Awake()
        {
            stateMachine = FindObjectOfType<StateMachine>();
            if (stateMachine != null)
            {
                stateMachine.RegisterStateHandler(State.Start, this);
            }
        }
        public override void OnEnter()
        {
            if (SceneManager.GetActiveScene().buildIndex != 0)
            {
                SceneManager.LoadScene(0);
            }
        }

        public override void OnExit()
        {
            //generate GameLevel?
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}