namespace DouduckGame {
	public abstract class IGameEventBase {
		public abstract IGameEventSubject NeedSubject(uint uiGameEventId);
	}
}