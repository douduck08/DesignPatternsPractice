## DesignPatternsPractice

My Practicing of 23 Design Patterns

## Design Patterns of GoF

#### Creational Patterns
Patterns | Description
--- | ---
Abstract Factory | 一個進階的Factory Method，可以用抽象的方法要求物件，再依照情況決定要提供給使用者的實作類別。
Builder | 將複雜物件的建立分離，另外交由一個類別來組裝(依照參數添加member class)。
Factory Method | 當物件的建立需要多個步驟，另外封裝成一個介面，將物件的建立過程留到子類別來實現。Template Method的建構版。
Prototype | 預先建立後複製。讀取資源檔便是一個例子。
Singleton | 只建構一個，且方便呼叫。利用靜態成員實作，屬實作類別，類似於全域變數，要小心過度濫用。

#### Structural Patterns
Patterns | Description
--- | ---
Adapter | 將原類別用組合的方式包覆，轉接介面。也可以使原類別與客戶端分離，方便替換實作方式。
Bridge | 將抽象與實作分離，分別擁有自己的介面。適合用於兩者關係是多對多交叉組合時。
Composite | 樹狀的階層管理，子節點會依賴父節點的存續。
Decorator | 透過實作一個可以重複包覆的類別，讓類別可以被重複擴充新的功能，而不必修改原始類別。這個實作類別中會包含一個自己的介面類別作為成員。
Facade | 用一個類別包覆所有需要的子系統，整合為單一個互動介面提供呼叫。
Flyweight | 讓一群小物件共享數值，用容器統一管理(共用記憶體)。
Proxy | 使用一個新的實作包覆舊的實作，成為有額外功能的替代類別。有虛擬/保護/遠端等代理方式。

#### Behavioral Patterns
Patterns | Description
--- | ---
Chain of Responsibility | 將一群處理需求的類別串聯，依序傳遞來自外部的需求，直到需求被某個類別接受為止。可以取代switch。
Command | 將執行的需求封裝成物件，讓客戶端的請求可以統一管理。
Interpreter | 解譯器。
Iterator | 對於一群物件，透過泛用容器，逐一對所有物件執行動作。
Mediator | 子系統的溝通者，降低子系統間的相依姓。在每個子系統中實作Colleage，由某Colleage呼叫Mediator，傳送通知給其他Colleage。
Memento | 在不影響目標類別封裝的狀況下，儲存目標的狀態在外部，並且可以用於還原目標的狀態。由於是目標類別主動進行Memento，所以可以彈性管理複數個外部儲存的狀態。
Observer | 一對多的事件-處理者關係，可以自由訂閱與退訂事件。
State | 狀態機，使一個類別可以拆分成數個可獨立維護的狀態(情境)。有需要可對狀態類別進行狀態機的"相依性注入"。
Strategy | 將類別中的特定function封裝為另一個類別來組合，使得不同實體可以有不同的功能差異，取代if-else。
Template Method | 將演算法中固定的步驟封裝，只開放有變化需求的部分，使子類別實作時不需每次都重複實作相同的部分。
Visitor | 透過在類別中實作一個函式傳入Visitor，讓類別主動使用這個Visitor來達到訪問的功能。透過繼承設計不同的Visitor，即可在不變動目標類別的情況下，增加訪問這個類別的方法。

