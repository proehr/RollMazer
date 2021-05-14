using UnityEngine;

namespace UnityTemplateProjects
{
    public class PauseHandler : StateHandler
    {
        [SerializeField] private CanvasGroup pauseMenu;
        public override void Awake()
        {
            stateMachine = FindObjectOfType<StateMachine>();
            if (stateMachine != null)
            {
                stateMachine.RegisterStateHandler(State.Pause, this);
            }

            pauseMenu = GetComponent<CanvasGroup>();
            pauseMenu.alpha = 0f;
            pauseMenu.interactable = false;
        }
        public override void OnEnter()
        {
            Time.timeScale = 0f;
            pauseMenu.interactable = true;
            pauseMenu.alpha = 1f;
        }

        public override void OnExit()
        {
            Time.timeScale = 1f;
            pauseMenu.interactable = false;
            pauseMenu.alpha = 0f;
        }

        public void ResumeGame()
        {
            stateMachine.TriggerTransition(Transition.PlayGame);
        }

        public void ExitGame()
        {
            stateMachine.TriggerTransition(Transition.StartGame);
        }
    }
}