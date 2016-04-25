## DesignPatternsPractice

My Practicing of 23 Design Patterns

## Design Patterns of GoF

#### Creational Patterns
- Abstract Factory
- Builder: 將複雜物件的建立分離，另外交由一個類別來組裝(依照參數添加member class)。
- Factory Method: 當物件的建立需要多個步驟，另外封裝成一個介面，將物件的建立過程留到子類別來實現。Template Method的建構版。
- Prototype
- Singleton: 只建構一個，且方便呼叫。利用靜態成員實作，屬實作類別，類似於全域變數，要小心過度濫用。

#### Structural Patterns
- Adapter
- Bridge: 將抽象與實作分離，分別擁有自己的介面。適合用於兩者關係是多對多交叉組合時。
- Composite
- Decorator
- Facade: 用一個類別包覆所有需要的子系統，整合為單一個互動介面提供呼叫。
- Flyweight: 讓一群相同的小物件共享數值。
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
- Strategy: 將類別中的特定function封裝為另一個類別來組合，使得不同實體可以有不同的功能差異，取代if-else。
- Template Method: 將演算法中固定的步驟封裝，只開放有變化需求的部分，使子類別實作時不需每次都重複實作相同的部分。
- Visitor

