using CookingPrototype.Controllers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI {
	public class StartWindow : MonoBehaviour {

		public TMP_Text GoalText = null;
		public Button StartButton = null;

		bool _isInit = false;

		void Start() {
			var gc = GameplayController.Instance;
			GoalText.text = $"{gc.OrdersTarget}";
		}

		void Init() {
			var gc = GameplayController.Instance;
			StartButton?.onClick.AddListener(gc.StartGame);
			_isInit = true;
		}

		public void Hide() {
			gameObject.SetActive(false);
		}

		public void Show() {
			if (_isInit) {
				Init();
			}
			gameObject.SetActive(true);
		}
	}
}