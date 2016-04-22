## DesignPatternsPractice

My Practicing of 23 Design Patterns

## Design Patterns of GoF

#### Creational Patterns
- Abstract Factory
- Builder
- Factory Method
- Prototype
- Singleton: 只建構一個，且方便呼叫。利用靜態成員實作，屬實作類別，類似於全域變數，要小心過度濫用。

#### Structural Patterns
- Adapter
- Bridge
- Composite
- Decorator
- Facade: 用一個類別包覆所有需要的子系統，整合為單一個互動介面提供呼叫。
- Flyweight
- Proxy

#### Behavioral Patterns
- Chain of Responsibility
- Command
- Interpreter
- Iterator
- Mediator: 子系統的溝通者，降低子系統間的相依姓。在每個子系統中實作Colleage，由某Colleage呼叫Mediator，傳送通知給其他Colleage。
- Memento
- Observer
- State: 狀態機，使一個類別可以拆分成數個可獨立維護的狀態(情境)。有需要可對狀態類別進行狀態機的"相依性注入"。
- Strategy
- Template Method
- Visitor

