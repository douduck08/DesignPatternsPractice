using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DouduckGame {
	public class GameEventSystem {
		private IGameEventBase m_GameEventBase;
		private Dictionary<uint, IGameEventSubject> m_GameEvents;
		public GameEventSystem(IGameEventBase oGameEventBase) {
			m_GameEventBase = oGameEventBase;
			m_GameEvents = new Dictionary<uint, IGameEventSubject>();
		}

		public void RegisterObserver(uint uiGameEventId, IGameEventObserver Observer) {
			IGameEventSubject sub_ = GetSubject(uiGameEventId);
			if (sub_ != null) {
				sub_.Attach(Observer);
			}
		}

		public void UnregisterObserver(uint uiGameEventId, IGameEventObserver Observer) {
			IGameEventSubject sub_ = GetSubject(uiGameEventId);
			if (sub_ != null) {
				sub_.Detach(Observer);
			}
		}

		public void NotifySubject(uint uiGameEventId, System.Object oParam = null) {
			if (m_GameEvents.ContainsKey(uiGameEventId) == false) {
				Debugger.LogError("[GameEventSystem] Subject id = " + uiGameEventId + " was not set");
				return;
			}
			if (oParam != null) {
				m_GameEvents[uiGameEventId].SetParam(oParam);
			}
			m_GameEvents[uiGameEventId].Notify();
		}

		private void AddGameEventSubject(uint uiGameEventId, IGameEventSubject Subject) {
			m_GameEvents.Add(uiGameEventId, Subject);
		}

		private IGameEventSubject GetSubject(uint uiGameEventId) {
			if (m_GameEvents.ContainsKey(uiGameEventId)) {
				return m_GameEvents[uiGameEventId];
			} else {
				IGameEventSubject sub_ = m_GameEventBase.NeedSubject(uiGameEventId);
				if (sub_ == null) {
					Debugger.LogError("[GameEventSystem] No subject id = " + uiGameEventId);
					return null;
				} else {
					AddGameEventSubject(uiGameEventId, sub_);
					return sub_;
				}
			}
		}
	}
}