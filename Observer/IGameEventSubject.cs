using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DouduckGame {
	public abstract class IGameEventSubject {
		private List<IGameEventObserver> m_Observers = new List<IGameEventObserver>();
		private System.Object m_Param = null;

		public void Attach(IGameEventObserver theObserver) {
			m_Observers.Add(theObserver);
		}

		public void Detach(IGameEventObserver theObserver) {
			m_Observers.Remove(theObserver);
		}

		public void Notify() {
			for (int i = m_Observers.Count - 1; i >= 0; i--) {
				m_Observers[i].GetNotify(m_Param);
			}

		}

		public virtual void SetParam(System.Object Param) {
			m_Param = Param;
		}
	}
}